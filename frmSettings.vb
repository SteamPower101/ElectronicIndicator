Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Populate form with current values of all variables

        Dim fmtL As String = "0.000"     ' numeric formats for length, pressure and voltage units
        Dim fmtP As String = "0.0"
        Dim fmtV As String = "0.000"

        radImperial.Checked = True
        radMetric.Checked = False
        If flgMetric Then
            radImperial.Checked = False
            radMetric.Checked = True
            fmtL = "0.0"
            fmtP = "0.000"
        End If

        txtBore.Text = Format(bore, fmtL)
        txtStroke.Text = Format(stroke, fmtL)
        txtConrod.Text = Format(conrod, fmtL)
        txtAvg.Text = averageReadings.ToString()
        txtPPR.Text = encoderPPR.ToString()

        txtCylLoP.Text = Format(Cyl_lowP, fmtP)
        txtCylLoV.Text = Format(Cyl_lowV, fmtV)
        txtCylHiP.Text = Format(Cyl_hiP, fmtP)
        txtCylHiV.Text = Format(Cyl_hiV, fmtV)
        txtSCLoP.Text = Format(SC_lowP, fmtP)
        txtSCLoV.Text = Format(SC_lowV, fmtV)
        txtSCHiP.Text = Format(SC_hiP, fmtP)
        txtSCHiV.Text = Format(SC_hiV, fmtV)

        'If flgMeasureSC Then    ' gray out if not using this sensor
        'chkSChest.Checked = True
        'Else
        'chkSChest.Checked = False
        'End If
        chkSChest.Checked = flgMeasureSC
        chkSChest_CheckedChanged(chkSChest, New EventArgs())

        txtBPress.Text = Format(boilerPress, fmtP)
        txtBTemp.Text = Format(boilerTemp, "0")

        If flgBoilerSaturated Then    ' gray out if not using this sensor
            chkBSaturated.Checked = True
            txtBTemp.ForeColor = Color.Gray
        Else
            chkBSaturated.Checked = False
            txtBTemp.ForeColor = SystemColors.WindowText
        End If

        Try
            nudDFactor.Value = CDec(dFactor * 100)  ' display percentage value
            nudClearance.Value = CDec(clearance * 100)
        Catch ex As Exception
            MsgBox("Diagram Factor or Clearance value in settings file was out of range.  Resetting to defaults.")
            nudDFactor.Value = 80
            nudClearance.Value = 5
        End Try
        nudDFactor_Validating(nudDFactor, New CancelEventArgs())
        nudClearance_Validating(nudClearance, New CancelEventArgs())



        ' load cal unit combo boxes
        cbxCylUnit.DataSource = [Enum].GetValues(GetType(PUnits))
        cbxSCUnit.DataSource = [Enum].GetValues(GetType(PUnits))
        cbxCylUnit.SelectedItem = Cyl_PUnits
        cbxSCUnit.SelectedItem = SC_PUnits


    End Sub

    Sub SetUnitLabels()
        ' sets the unit labels on all the forms


        If flgMetric Then
            lblLength1.Text = strMUnit_L
            lblLength2.Text = strMUnit_L
            lblLength3.Text = strMUnit_L
            lblBPress.Text = strMUnit_P
            lblBTemp.Text = strMUnit_T
            frmMainScreen.lblUnitMEP.Text = strMUnit_P
            frmMainScreen.lblUnitWork.Text = strMUnit_W
            frmMainScreen.lblUnitPower.Text = strMUnit_Pow
            frmMainScreen.lblUnitWaterRate.Text = strMUnit_WR
            frmMainScreen.lblUnitWaterUse.Text = strMUnit_WU

        Else
            lblLength1.Text = strIUnit_L
            lblLength2.Text = strIUnit_L
            lblLength3.Text = strIUnit_L
            lblBPress.Text = strIUnit_P
            lblBTemp.Text = strIUnit_T
            lblCylUnit.Text = Cyl_PUnits.ToString ' FIXME do all these
            frmMainScreen.lblUnitMEP.Text = strIUnit_P
            frmMainScreen.lblUnitWork.Text = strIUnit_W
            frmMainScreen.lblUnitPower.Text = strIUnit_Pow
            frmMainScreen.lblUnitWaterRate.Text = strIUnit_WR
            frmMainScreen.lblUnitWaterUse.Text = strIUnit_WU

        End If


    End Sub


    Private Sub radImperial_CheckedChanged(sender As Object, e As EventArgs) Handles radImperial.CheckedChanged
        flgMetric = False
        SetUnitLabels()

    End Sub

    Private Sub radMetric_CheckedChanged(sender As Object, e As EventArgs) Handles radMetric.CheckedChanged
        flgMetric = True
        SetUnitLabels()
    End Sub



    Private Sub txtBore_Validating(sender As Object, e As CancelEventArgs) Handles txtBore.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtBore.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtBore.SelectAll()
            txtBore.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtBore.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            bore = number
        End If

    End Sub

    Private Sub txtStroke_Validating(sender As Object, e As CancelEventArgs) Handles txtStroke.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtStroke.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtStroke.SelectAll()
            txtStroke.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtStroke.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            stroke = number
        End If

    End Sub
    Private Sub txtConrod_Validating(sender As Object, e As CancelEventArgs) Handles txtConrod.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtConrod.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtConrod.SelectAll()
            txtConrod.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtConrod.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            conrod = number
        End If

    End Sub

    Private Sub txtBPress_Validating(sender As Object, e As CancelEventArgs) Handles txtBPress.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtBPress.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtBPress.SelectAll()
            txtBPress.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtBPress.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            boilerPress = number
            frmMainScreen.lblBoilerState.Text = boilerPress.ToString & " " & strIUnit_P &
                    ", " & boilerTemp.ToString & " " & strIUnit_T
        End If

    End Sub
    Private Sub txtBTemp_Validating(sender As Object, e As CancelEventArgs) Handles txtBTemp.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtBTemp.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtBTemp.SelectAll()
            txtBTemp.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtBTemp.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            boilerTemp = number
            frmMainScreen.lblBoilerState.Text = boilerPress.ToString & " " & strIUnit_P &
                    ", " & boilerTemp.ToString & " " & strIUnit_T
        End If

    End Sub


    Private Sub txtPPR_Validating(sender As Object, e As CancelEventArgs) Handles txtPPR.Validating
        ' accept only positive real numbers
        Dim number As Integer

        If Not Integer.TryParse(txtPPR.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtPPR.SelectAll()
            txtPPR.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtPPR.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            encoderPPR = number
        End If

    End Sub

    Private Sub txtAvg_Validating(sender As Object, e As CancelEventArgs) Handles txtAvg.Validating
        ' accept only positive real numbers
        Dim number As Integer

        If Not Integer.TryParse(txtAvg.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtAvg.SelectAll()
            txtAvg.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtAvg.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            averageReadings = number
        End If

    End Sub



    Private Sub chkBSaturated_CheckedChanged(sender As Object, e As EventArgs) Handles chkBSaturated.CheckedChanged
        If chkBSaturated.Checked = True Then
            ' FIXME
            'boilerTemp = IF97_Tsat(boilerPress)
            ' txtBTemp.Text=format(boilerTemp,"0.0")
            txtBTemp.ReadOnly = True
            txtBTemp.BackColor = Color.Gray

        Else
            txtBTemp.ReadOnly = False
            txtBTemp.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub cbxCylUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCylUnit.SelectedIndexChanged
        Cyl_PUnits = cbxCylUnit.SelectedItem
        lblCylUnit.Text = Cyl_PUnits.ToString
        SetCalPressures()
    End Sub

    Private Sub cbxSCUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSCUnit.SelectedIndexChanged
        SC_PUnits = cbxSCUnit.SelectedItem
        lblSCUnit.Text = SC_PUnits.ToString
        SetCalPressures()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub


    Private Sub txtCylLoP_Validating(sender As Object, e As CancelEventArgs) Handles txtCylLoP.Validating
        ' accept only real numbers.  Allow negative for absolute sensors with gauge pressure given.
        Dim number As Double

        If Not Double.TryParse(txtCylLoP.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtCylLoP.SelectAll()
            txtCylLoP.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtCylLoP.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            Cyl_lowP = number
            SetCalPressures()
        End If

    End Sub

    Private Sub txtCylLoV_Validating(sender As Object, e As CancelEventArgs) Handles txtCylLoV.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtCylLoV.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtCylLoV.SelectAll()
            txtCylLoV.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtCylLoV.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            Cyl_lowV = number
        End If

    End Sub


    Private Sub txtCylHiP_Validating(sender As Object, e As CancelEventArgs) Handles txtCylHiP.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtCylHiP.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtCylHiP.SelectAll()
            txtCylHiP.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtCylHiP.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            Cyl_hiP = number
            SetCalPressures()
        End If

    End Sub

    Private Sub txtCylHiV_Validating(sender As Object, e As CancelEventArgs) Handles txtCylHiV.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtCylHiV.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtCylHiV.SelectAll()
            txtCylHiV.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtCylHiV.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            Cyl_hiV = number
        End If

    End Sub


    Private Sub txtSCLoP_Validating(sender As Object, e As CancelEventArgs) Handles txtSCLoP.Validating
        ' accept only real numbers.  Allow negative for absolute sensors with gauge pressure given.
        Dim number As Double

        If Not Double.TryParse(txtSCLoP.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtSCLoP.SelectAll()
            txtSCLoP.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtSCLoP.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            SC_lowP = number
            SetCalPressures()
        End If

    End Sub

    Private Sub txtSCLoV_Validating(sender As Object, e As CancelEventArgs) Handles txtSCLoV.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtSCLoV.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtSCLoV.SelectAll()
            txtSCLoV.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtSCLoV.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            SC_lowV = number
        End If

    End Sub


    Private Sub txtSCHiP_Validating(sender As Object, e As CancelEventArgs) Handles txtSCHiP.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtSCHiP.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtSCHiP.SelectAll()
            txtSCHiP.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtSCHiP.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            SC_hiP = number
            SetCalPressures()
        End If

    End Sub

    Private Sub txtSCHiV_Validating(sender As Object, e As CancelEventArgs) Handles txtSCHiV.Validating
        ' accept only positive real numbers
        Dim number As Double

        If Not Double.TryParse(txtSCHiV.Text, number) OrElse
           number < 0 Then
            'Highlight all text and show highlight when not focused.
            txtSCHiV.SelectAll()
            txtSCHiV.HideSelection = False

            MessageBox.Show("Please enter a positive number.",
                            "invalid Data",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtSCHiV.HideSelection = True

            'Don't let the control lose focus.
            e.Cancel = True
        Else
            SC_hiV = number
        End If

    End Sub

    Private Sub chkSChest_CheckedChanged(sender As Object, e As EventArgs) Handles chkSChest.CheckedChanged
        If chkSChest.Checked = True Then
            flgMeasureSC = True
            txtSCLoP.ReadOnly = False
            txtSCLoP.ForeColor = SystemColors.WindowText
            txtSCHiP.ReadOnly = False
            txtSCHiP.ForeColor = SystemColors.WindowText
            txtSCLoV.ReadOnly = False
            txtSCLoV.ForeColor = SystemColors.WindowText
            txtSCHiV.ReadOnly = False
            txtSCHiV.ForeColor = SystemColors.WindowText

        Else
            flgMeasureSC = False
            txtSCLoP.ReadOnly = True
            txtSCLoP.ForeColor = SystemColors.ControlLight
            txtSCHiP.ReadOnly = True
            txtSCHiP.ForeColor = SystemColors.ControlLight
            txtSCLoV.ReadOnly = True
            txtSCLoV.ForeColor = SystemColors.ControlLight
            txtSCHiV.ReadOnly = True
            txtSCHiV.ForeColor = SystemColors.ControlLight

        End If
    End Sub

    Private Sub nudDFactor_Validating(sender As Object, e As CancelEventArgs) Handles nudDFactor.Validating
        dFactor = CDbl(nudDFactor.Value) / 100
        frmMainScreen.lblDFactor.Text = (dFactor * 100).ToString & "%"
    End Sub

    Private Sub nudClearance_Validating(sender As Object, e As CancelEventArgs) Handles nudClearance.Validating
        clearance = CDbl(nudClearance.Value) / 100
        frmMainScreen.lblClearance.Text = (clearance * 100).ToString & "%"
    End Sub
End Class