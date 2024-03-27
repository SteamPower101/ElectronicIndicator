Imports System.Reflection.Emit

Public Class frmLogPlot


    Sub DrawLogDiagram()
        ' puts pressure and volume on a log-log plot

        Dim i As Integer
        Dim x, y As Double
        Dim vSwept As Double = Math.PI * bore ^ 2 / 4 * stroke
        Dim vClear As Double = clearance * vSwept
        Dim vTot1000 As Double = (vClear + vSwept) / 1000
        Dim v As Double           ' current cylinder volume
        Dim p As Double             ' current cylinder pressure
        Dim cAngle As Double = 0   ' crank angle, in radians
        Dim deltaA As Double = 2 * Math.PI / nMeasuredPts     ' angle increment
        Dim s As Double             ' piston position from TDC, inch or mm
        Dim r As Double = stroke / 2  ' crank radius
        Dim fracStroke As Double    ' fraction of stroke piston is at, 0 to 1.0

        Dim pmin, pmax, vmin, vmax As Double

        Chart1.Series("Series1").Points.Clear()

        pmax = Cyl_psig(0)
        pmin = Cyl_psig(0)
        ' scale volumes by 1000 to avoid problems with logs of small numbers
        vmin = vClear / vTot1000
        vmax = (vClear + vSwept) / vTot1000

        For i = 0 To nMeasuredPts - 1

            ' calculates piston positions
            x = r * Math.Cos(cAngle) + conrod * Math.Sqrt(1 - (r / conrod * Math.Sin(cAngle)) ^ 2)
            fracStroke = (r + conrod - x) / stroke
            cAngle += deltaA

            v = (vClear + fracStroke * vSwept) / vTot1000
            p = Cyl_psig(i) + atmPsia          ' absoute pressure is used

            If p < 1 Then p = 1              ' avoid crash due to log of negative pressures
            If p > pmax Then pmax = p
            If p < pmin Then pmin = p

            Chart1.Series("Series1").Points.AddXY(v, p)

        Next

        ' adjust limits to best show data
        Chart1.ChartAreas(0).AxisX.Minimum = Math.Floor(vmin) * 0.9
        Chart1.ChartAreas(0).AxisX.Maximum = Math.Ceiling(vmax) * 1.1
        Chart1.ChartAreas(0).AxisY.Minimum = Math.Floor(pmin) * 0.9
        Chart1.ChartAreas(0).AxisY.Maximum = Math.Ceiling(pmax) * 1.1
        Chart1.ChartAreas(0).AxisX.IsLogarithmic = True
        Chart1.ChartAreas(0).AxisY.IsLogarithmic = True

    End Sub

    Private Sub analysis_Load(sender As Object, e As EventArgs) Handles Me.Load
        DrawLogDiagram()
    End Sub

    Private Sub nudClearance_ValueChanged(sender As Object, e As EventArgs) Handles nudClearance.ValueChanged
        clearance = CDbl(nudClearance.Value) / 100
        DrawLogDiagram()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class