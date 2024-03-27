Public Class frmData

    Private Sub frmData_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim i As Integer

        With Me.dgvData
            .Columns(0).DefaultCellStyle.Format = "0.0"
            .Columns("colCylP").DefaultCellStyle.Format = "0.0"
            .Columns("colSCP").DefaultCellStyle.Format = "0.0"
        End With


        For i = 0 To nMeasuredPts - 1
            dgvData.Rows.Add()
        Next


        For i = 0 To nMeasuredPts - 1
            Me.dgvData(0, i).Value = i / nMeasuredPts * 360
            Me.dgvData(1, i).Value = rawCylReadings(i)
            Me.dgvData(2, i).Value = rawSCReadings(i)
            Me.dgvData(3, i).Value = Cyl_psig(i)
            Me.dgvData(4, i).Value = SC_psig(i)

        Next



    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveMeasurements()
    End Sub
End Class