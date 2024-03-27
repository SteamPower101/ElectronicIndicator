Imports System.IO

Module fileFunctions

    ' Handles the settings file and report printing.
    Dim s As String
    Sub SaveMeasurements()
        ' Saves the last set of ADC values and calculated pressures
        Dim i As Integer
        Dim dlgSave As New SaveFileDialog()
        Dim f As IO.StreamWriter

        dlgSave.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        dlgSave.FilterIndex = 1
        dlgSave.RestoreDirectory = True

        If dlgSave.ShowDialog() = DialogResult.OK Then

            f = IO.File.CreateText(dlgSave.FileName)

            f.WriteLine("Engine Indicator App measurement file")
            f.WriteLine(testTitle)
            f.WriteLine(testDescription.Replace("\n", vbCrLf))
            f.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
            f.WriteLine("Crank Angle, Cylinder ADC, Steam Chest ADC, Cylinder Pressure, Steam Chest Pressure")

            For i = 0 To nMeasuredPts - 1
                f.WriteLine(String.Format("{0},{1},{2},{3},{4}",
                    i / nMeasuredPts * 360, rawCylReadings(i), rawSCReadings(i), Cyl_psig(i), SC_psig(i)))
            Next

            f.Close()

        End If

    End Sub












    Sub GetSettings()
        ' This gets hardware setup values from the last used (if a settings file
        ' is found) or leaves the default values in place.


        Dim s As String


        If IO.File.Exists(SettingsFN) Then

            Dim f As StreamReader = New StreamReader(SettingsFN)

            Try

                s = f.ReadLine()

                ' an empty file would cause an exception not handled by Try..Catch
                If s = Nothing Then
                    IO.File.Delete(SettingsFN)
                    MessageBox.Show("Settings file was corrupt, using default values.", "File Bad")
                    Exit Try
                End If
                s = Trim(f.ReadLine.Split(":"c)(1))
                If s <> AppVersion Then
                    MessageBox.Show("Settings file is from old version of this App.  Check values.", "Old Version")
                End If
                s = f.ReadLine
                testTitle = Split(s, ":", 2)(1)   ' only splits at first instance of colon
                s = f.ReadLine.Replace("\n", vbCrLf)   ' put line breaks back in
                testDescription = Split(s, ":", 2)(1)
                flgMetric = Convert.ToBoolean(f.ReadLine.Split(":"c)(1))
                bore = CDbl(f.ReadLine.Split(":"c)(1))
                stroke = CDbl(f.ReadLine.Split(":"c)(1))
                conrod = CDbl(f.ReadLine.Split(":"c)(1))
                encoderPPR = CInt(f.ReadLine.Split(":"c)(1))
                averageReadings = CInt(f.ReadLine.Split(":"c)(1))
                [Enum].TryParse(Of PUnits)(f.ReadLine.Split(":"c)(1), Cyl_PUnits)

                Cyl_lowP = CDbl(f.ReadLine.Split(":"c)(1))
                Cyl_lowV = CDbl(f.ReadLine.Split(":"c)(1))
                Cyl_hiP = CDbl(f.ReadLine.Split(":"c)(1))
                Cyl_hiV = CDbl(f.ReadLine.Split(":"c)(1))
                flgMeasureSC = Convert.ToBoolean(f.ReadLine.Split(":"c)(1))
                [Enum].TryParse(Of PUnits)(f.ReadLine.Split(":"c)(1), SC_PUnits)

                SC_lowP = CDbl(f.ReadLine.Split(":"c)(1))
                SC_lowV = CDbl(f.ReadLine.Split(":"c)(1))
                SC_hiP = CDbl(f.ReadLine.Split(":"c)(1))
                SC_hiV = CDbl(f.ReadLine.Split(":"c)(1))

                boilerPress = CDbl(f.ReadLine.Split(":"c)(1))
                boilerTemp = CDbl(f.ReadLine.Split(":"c)(1))
                flgBoilerSaturated = Convert.ToBoolean(f.ReadLine.Split(":"c)(1))
                frmMainScreen.lblBoilerState.Text = boilerPress.ToString & " " & strIUnit_P &
                    ", " & boilerTemp.ToString & " " & strIUnit_T

                dFactor = CDbl(f.ReadLine.Split(":"c)(1)) / 100
                frmMainScreen.lblDFactor.Text = (dFactor * 100).ToString & "%"
                clearance = CDbl(f.ReadLine.Split(":"c)(1)) / 100
                frmMainScreen.lblClearance.Text = (clearance * 100).ToString & "%"

                f.Close()

                SetCalPressures()   'converts to psig cal values

            Catch
                ' something was wrong with the file, so delete it

                f.Close()
                IO.File.Delete(SettingsFN)
                MessageBox.Show("Settings file was corrupt, using default values.", "File Bad")
            End Try



        Else    ' use defaults

            MessageBox.Show("Settings file not found, using default values.", "File Not Found")

        End If

        frmSettings.SetUnitLabels()

    End Sub

    Sub SaveSettings()

        ' always overwrites previous file
        Dim f As IO.StreamWriter = IO.File.CreateText(SettingsFN)
        Dim s As String

        f.WriteLine("Hardware settings for EngineIndicatorApp.  Colon is the delimiter.")
        f.WriteLine("Software version: " & AppVersion)
        f.WriteLine("Test title:" & testTitle)
        s = testDescription.Replace(vbCrLf, "\n")
        f.WriteLine("Test description:" & s) 'convert line breaks 
        f.WriteLine("Are units metric?: " & flgMetric.ToString())
        f.WriteLine("Cylinder bore: " & bore.ToString())
        f.WriteLine("Cylinder stroke: " & stroke.ToString())
        f.WriteLine("Conrod length: " & conrod.ToString())
        f.WriteLine("Encoder P/R: " & encoderPPR.ToString())
        f.WriteLine("Number of readings in average: " & averageReadings.ToString())
        f.WriteLine("Cylinder pressure transducer calibration units: " & Cyl_PUnits.ToString())
        f.WriteLine("Cylinder pressure transducer low calibration pressure: " & Cyl_lowP.ToString())
        f.WriteLine("Cylinder pressure transducer low calibration voltage: " & Cyl_lowV.ToString())
        f.WriteLine("Cylinder pressure transducer high calibration pressure: " & Cyl_hiP.ToString())
        f.WriteLine("Cylinder pressure transducer high calibration voltage: " & Cyl_hiV.ToString())
        f.WriteLine("Was steam chest pressure measured?: " & flgMeasureSC.ToString())
        f.WriteLine("Steam chest pressure transducer calibration units: " & SC_PUnits.ToString())
        f.WriteLine("Steam chest pressure transducer low calibration pressure: " & SC_lowP.ToString())
        f.WriteLine("Steam chest pressure transducer low calibration voltage: " & SC_lowV.ToString())
        f.WriteLine("Steam chest pressure transducer high calibration pressure: " & SC_hiP.ToString())
        f.WriteLine("Steam chest pressure transducer high calibration voltage: " & SC_hiV.ToString())
        f.WriteLine("Stated boiler pressure: " & boilerPress.ToString())
        f.WriteLine("Stated boiler temperature: " & boilerTemp.ToString())
        f.WriteLine("Stated boiler steam is saturated: " & flgBoilerSaturated.ToString())
        f.WriteLine("Assumed diagram factor %: " & (dFactor * 100).ToString())
        f.WriteLine("Assumed cylinder clearance %: " & (clearance * 100).ToString())


        f.Close()

    End Sub










End Module
