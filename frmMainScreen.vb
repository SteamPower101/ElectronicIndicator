Imports System.ComponentModel


Public Class frmMainScreen


    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Setup()
        Timer1.Interval = 1000
        Timer1.Start()

        Chart1.Series("Series1").Points.Clear() ' clear out the default chart
        Chart1.Series("Series2").Points.Clear()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CheckUnoConnection()

    End Sub

    Private Sub btnOneRev_Click(sender As Object, e As EventArgs) Handles btnOneRev.Click
        cyclesToMeasure = 1
        MeasureDisplay(cyclesToMeasure)
    End Sub

    Private Sub btnAvgRevs_Click(sender As Object, e As EventArgs) Handles btnAvgRevs.Click
        cyclesToMeasure = averageReadings
        MeasureDisplay(cyclesToMeasure)
    End Sub

    Sub MeasureDisplay(nAvg As Integer)
        UnoMeasure(nAvg)
        CalcDiagram()
        CalcIMEP()

        txtCalcRPM.Text = Format(engineRPM, "0")

        If flgMetric Then
            txtCalcIMEP.Text = Format(IMEP_psig / psiPerBar, "0.000")
            txtCalcWork.Text = Format(iWorkPerCycle_ftlb * dFactor * NmPerFtLb, "0.00")
            txtCalcHP.Text = Format(iPower_hp * dFactor * kWPerHP, "0.000")
        End If
        txtCalcIMEP.Text = Format(IMEP_psig, "0.0")
        txtCalcWork.Text = Format(iWorkPerCycle_ftlb * dFactor, "0.00")
        txtCalcHP.Text = Format(iPower_hp * dFactor, "0.000")

    End Sub

    Private Sub frmMainScreen_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SaveSettings()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub txtTestTitle_Validating(sender As Object, e As CancelEventArgs) Handles txtTestTitle.Validating
        testTitle = txtTestTitle.Text
    End Sub

    Private Sub txtDescription_Validating(sender As Object, e As CancelEventArgs) Handles txtDescription.Validating
        testDescription = txtDescription.Text
    End Sub

    Private Sub MeasDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeasDataToolStripMenuItem.Click
        frmData.ShowDialog()
    End Sub

    Private Sub LogPlotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogPlotToolStripMenuItem.Click
        frmLogPlot.Chart1.Series("Series1").Points.Clear()    ' avoids crashing due to log-log plot and default data
        frmLogPlot.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
