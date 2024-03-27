Module unoComms
    ' Functions for communicating with the Uno.

    '   The protocol is:
    '       Send        Should Receive
    '       ----        --------------
    '       ?           EIA             checks if Uno is connected to current port
    '       P n         n               sets the number of encoder pulses per revolution
    '       S 0/1       0/1             sets flag if steam chest pressures should be recorded
    '       M n         n readings + END   measure n revolutions and return pressure counts
    '
    '   ReadLine & WriteLine function used so complete strings received/sent

    Sub CheckUnoConnection()
        ' This is executed on each Timer1 tick.  If there was a connection, it
        ' checks the connection is still there.  If there wasn't, it goes through
        ' the list of serial ports to look for the Uno.
        ' The Uno responds to the "?" string with a "EIA" string.



        If flgUnoConnected Then    ' Check if Uno is still connected

            If flgUnoBusy = False Then
                flgUnoBusy = True
                If UnoPort.IsOpen Then
                    Try
                        UnoPort.WriteLine("?")
                        Dim reply() As String = Split(Trim(UnoPort.ReadLine()).Replace(vbCr, "").Replace(vbLf, ""))
                        If reply(0) <> "EIA" Then
                            UnoHasDisonnected()
                        Else
                            setRPM(reply(1))
                        End If
                    Catch ex As TimeoutException
                        UnoHasDisonnected()
                    End Try
                Else
                    UnoHasDisonnected()
                End If
                flgUnoBusy = False
            End If

        Else   ' If not connected to the Uno, look for a connection.

            For Each sp As String In My.Computer.Ports.SerialPortNames
                Try
                    UnoPort.PortName = sp
                    UnoPort.Open()
                    UnoPort.WriteLine("?")
                    Dim reply() As String = Split(Trim(UnoPort.ReadLine()).Replace(vbCr, "").Replace(vbLf, ""))
                    If reply(0) = "EIA" Then
                        setRPM(reply(1))
                        UnoHasConnected()
                        Exit For
                    End If
                Catch
                    UnoPort.Close()
                End Try
            Next
        End If
    End Sub
    Sub UnoMeasure(cycles As Integer)
        ' instruct Uno to take measurements and receive results

        Dim i As Integer = 0
        Dim inStr As String
        flgUnoBusy = True

        Try
            If cycles = 1 Then
                UnoPort.WriteLine("M 1")
            Else
                UnoPort.WriteLine("M " & cycles.ToString)
            End If
        Catch ex As Exception
            MsgBox("Failed to send measure command to Uno." & ex.ToString)
            flgUnoBusy = False
            Return
        End Try


        ' now the Uno should reply with a series of readings
        UnoPort.ReadTimeout = longTimeout   ' allow Uno to collect measurements
        Try
            Do
                inStr = UnoPort.ReadLine().Replace(vbCr, "").Replace(vbLf, "")
                If Trim(inStr) = "END" Then
                    Exit Do
                Else
                    rawCylReadings(i) = CInt(inStr.Split(","c)(0))
                    If flgMeasureSC Then
                        rawSCReadings(i) = CInt(inStr.Split(","c)(1))
                    End If
                    i += 1
                End If
            Loop
        Catch ex As Exception
            MsgBox("Failed to read measurments back from Uno." & ex.ToString)
            flgUnoBusy = False
            Return
        End Try

        UnoPort.ReadTimeout = shortTimeout
        nMeasuredPts = i


        flgUnoBusy = False
    End Sub
    Sub UnoSetup()
        ' sends basic measurement parameters

        Dim str As String

        flgUnoBusy = True

        ' send encoder pulses per rev value 
        Try
            UnoPort.WriteLine("P " & encoderPPR.ToString)
            str = Trim(UnoPort.ReadLine()).Replace(vbCr, "").Replace(vbLf, "")      ' Uno should reply with the number
        Catch ex As Exception
            MsgBox("Failed to send encoder P/R to Uno." & vbCrLf & ex.ToString)
        End Try
        If Trim(str) <> encoderPPR.ToString Then
            MsgBox("Uno replied with wrong encoder P/R.")
        End If

        ' send flag for steam chest measurement
        Try
            If flgMeasureSC Then
                UnoPort.WriteLine("S 1")
            Else
                UnoPort.WriteLine("S 0")
            End If
            str = Trim(UnoPort.ReadLine()).Replace(vbCr, "").Replace(vbLf, "")      ' Uno should reply with the number
        Catch ex As Exception
            MsgBox("Failed to send steam chest measurement flag to Uno." & vbCrLf & ex.ToString)
        End Try
        If Trim(str) <> "1" And Trim(str) <> "0" Then
            MsgBox("Uno replied with wrong steam chest measurement flag.")
        End If

        flgUnoBusy = False
    End Sub

    Sub UnoHasConnected()


        ' set of interface changes when a connection is found
        flgUnoConnected = True
        frmMainScreen.lblComStatus.Text = "Connected"
        frmMainScreen.lblComStatus.BackColor = Color.Green

        UnoSetup()

    End Sub
    Sub UnoHasDisonnected()
        ' set of interface changes when connection drops out
        flgUnoConnected = False
        Try
            UnoPort.Close()
        Catch
        End Try
        frmMainScreen.lblComStatus.Text = "NOT Connected"
        frmMainScreen.lblComStatus.BackColor = Color.Red
    End Sub



End Module
