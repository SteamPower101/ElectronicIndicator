Module calculations

    Public Sub setRPM(revTime As Integer)
        ' revTime is the time in milliseconds.  If the engine is running too slow (e.g., < 30 rpm),
        ' revTime is zero.
        If revTime > 0 Then
            engineRPM = 1 / CDbl(revTime) * 1000 * 60
        Else
            engineRPM = 0
        End If
        frmMainScreen.txtCalcRPM.Text = Format(engineRPM, "0")

    End Sub
    Public Sub CalcDiagram()
        ' assumes readings from Uno are stored in rawCylReadings() and rawSCReadings() arrays.
        ' assumes first reading is at TDC (crank angle = 0)
        Dim volts As Double
        Dim cAngle As Double = 0   ' crank angle, in radians
        Dim deltaA As Double = 2 * Math.PI / nMeasuredPts     ' angle increment
        Dim x As Double             ' piston position from TDC, inch or mm
        Dim r As Double = stroke / 2  ' crank radius

        frmMainScreen.Chart1.Series("Series1").Points.Clear()
        frmMainScreen.Chart1.Series("Series2").Points.Clear()
        frmReport.Chart1.Series("Series1").Points.Clear()

        For i = 0 To nMeasuredPts - 1

            ' convert ADC counts to pressures
            volts = CDbl(rawCylReadings(i)) * 5.0 / 1024 / cyclesToMeasure   ' assumes 5.0V on Uno
            Cyl_psig(i) = (volts - Cyl_lowV) / (Cyl_hiV - Cyl_lowV) * (Cyl_hiPpsig - Cyl_lowPpsig) + Cyl_lowPpsig
            If flgMeasureSC Then
                volts = CDbl(rawSCReadings(i)) * 5.0 / 1024 / cyclesToMeasure
                SC_psig(i) = (volts - SC_lowV) / (SC_hiV - SC_lowV) * (SC_hiPpsig - SC_lowPpsig) + SC_lowPpsig
            End If

            ' calculates piston positions
            x = r * Math.Cos(cAngle) + conrod * Math.Sqrt(1 - (r / conrod * Math.Sin(cAngle)) ^ 2)
            PistonPosition(i) = (r + conrod - x) / stroke   ' fraction of stroke piston is at, 0 to 1.0
            cAngle += deltaA

            ' plot diagram
            frmMainScreen.Chart1.Series("Series1").Points.AddXY(PistonPosition(i), Cyl_psig(i))
            frmReport.Chart1.Series("Series1").Points.AddXY(PistonPosition(i), Cyl_psig(i))
            If flgMeasureSC Then
                frmMainScreen.Chart1.Series("Series2").Points.AddXY(PistonPosition(i), SC_psig(i))
            End If


        Next


    End Sub

    Sub CalcIMEP()
        ' Uses trapezoid rule to get diagram area. Assumes BDC is at the middle point
        ' in the measurement set.
        Dim i As Integer
        Dim sum As Double = 0

        ' readings go from #0 at TDC to nMeasuredPts-1 as the last point before TDC.
        ' Then, 0 to nMeasuredPts/2 define expansion stroke and nMeasuredPts/2 to nMeasuredPts, #0 define return.
        ' There are nMeasuredPts/2 - 1 trapezoid areas to add.

        For i = 0 To nMeasuredPts / 2 - 1
            sum += (Cyl_psig(i) + Cyl_psig(i + 1)) / 2 * (PistonPosition(i + 1) - PistonPosition(i))
        Next

        For i = nMeasuredPts / 2 - 1 To nMeasuredPts - 2
            sum -= (Cyl_psig(i) + Cyl_psig(i + 1)) / 2 * (PistonPosition(i) - PistonPosition(i + 1))
        Next
        sum -= (Cyl_psig(nMeasuredPts - 1) + Cyl_psig(0)) / 2 * (PistonPosition(nMeasuredPts - 1) - PistonPosition(0))

        IMEP_psig = sum

        iWorkPerCycle_ftlb = Math.PI * bore ^ 2 / 4 * IMEP_psig * stroke / 12

        iPower_hp = iWorkPerCycle_ftlb * engineRPM / 33000

    End Sub

    Sub SetCalPressures()
        ' converts transducer calibration pressures from user units to psig



        Select Case Cyl_PUnits
            Case PUnits.PSIG
                Cyl_lowPpsig = Cyl_lowP
                Cyl_hiPpsig = Cyl_hiP
            Case PUnits.PSIA
                Cyl_lowPpsig = Cyl_lowP + atmPsia
                Cyl_hiPpsig = Cyl_hiP + atmPsia
            Case PUnits.BarG
                Cyl_lowPpsig = Cyl_lowP * psiPerBar
                Cyl_hiPpsig = Cyl_hiP * psiPerBar
            Case PUnits.BarA
                Cyl_lowPpsig = Cyl_lowP * psiPerBar + atmPsia
                Cyl_hiPpsig = Cyl_hiP * psiPerBar + atmPsia
            Case PUnits.MPaG
                Cyl_lowPpsig = Cyl_lowP * psiPerBar * 10
                Cyl_hiPpsig = Cyl_hiP * psiPerBar * 10
            Case PUnits.MPaA
                Cyl_lowPpsig = Cyl_lowP * psiPerBar * 10 + atmPsia
                Cyl_hiPpsig = Cyl_hiP * psiPerBar * 10 + atmPsia
        End Select

        Select Case SC_PUnits
            Case PUnits.PSIG
                SC_lowPpsig = SC_lowP
                SC_hiPpsig = SC_hiP
            Case PUnits.PSIA
                SC_lowPpsig = SC_lowP + atmPsia
                SC_hiPpsig = SC_hiP + atmPsia
            Case PUnits.BarG
                SC_lowPpsig = SC_lowP * psiPerBar
                SC_hiPpsig = SC_hiP * psiPerBar
            Case PUnits.BarA
                SC_lowPpsig = SC_lowP * psiPerBar + atmPsia
                SC_hiPpsig = SC_hiP * psiPerBar + atmPsia
            Case PUnits.MPaG
                SC_lowPpsig = SC_lowP * psiPerBar * 10
                SC_hiPpsig = SC_hiP * psiPerBar * 10
            Case PUnits.MPaA
                SC_lowPpsig = SC_lowP * psiPerBar * 10 + atmPsia
                SC_hiPpsig = SC_hiP * psiPerBar * 10 + atmPsia
        End Select

    End Sub
End Module
