Public Class frmReport
    Sub ReportPopulate()
        ' fills in the form before printing


        ' figure out unit labels
        Dim p As String = strIUnit_P
        Dim t As String = strIUnit_T
        Dim pow As String = strIUnit_Pow
        Dim w As String = strIUnit_W
        Dim wu As String = strIUnit_WU
        Dim wr As String = strIUnit_WR
        Dim fmtL As String = "0.000"     ' numeric formats for length, pressure
        Dim fmtP As String = "0.0"

        If flgMetric Then
            p = strMUnit_P
            t = strMUnit_T
            pow = strMUnit_Pow
            w = strMUnit_W
            wu = strMUnit_WU
            wr = strMUnit_WR
            fmtL = "0.0"
            fmtP = "0.000"
        End If


        lblDate.Text = "Date/Time: " & System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        lblTitle.Text = "Test Title: " & testTitle
        lblDescription.Text = testDescription

        lblEngineSpeed.Text = "Engine Speed: " & Format(engineRPM, "0") & " RPM."
        lblIMEP.Text = "Indicated Mean Effective Pressure (IMEP): " & Format(IMEP_psig, fmtP) & p
        lblWorkPerCycle.Text = "Work per Cycle*: " & Format(iWorkPerCycle_ftlb, "0.00") & w
        lblIHP.Text = "Indicated Power*: " & Format(iPower_hp, "0.00") & pow

        lblWaterRate.Text = "Water Rate: " & Format(waterRate_lbhphr, "0.00") & wr
        lblWaterUse.Text = "Water Use*: " & Format(waterUse_lbhr, "0.0") & wu
        lblBoilerState.Text = "Boiler Pressure at: " & Format(boilerPress, fmtP) & p &
            "; Temperature at: " & Format(boilerTemp, "0") & t
        lblDFactorClear.Text = "Diagram Factor: " & Format(dFactor, "P0") & "; Clearance: " & Format(clearance, "P1")

    End Sub
End Class