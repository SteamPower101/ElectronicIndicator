<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.colCAngle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRawCyl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRawSC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCylP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCAngle, Me.colRawCyl, Me.colRawSC, Me.colCylP, Me.colSCP})
        Me.dgvData.Location = New System.Drawing.Point(13, 134)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(606, 544)
        Me.dgvData.TabIndex = 0
        '
        'colCAngle
        '
        Me.colCAngle.HeaderText = "Crank Angle"
        Me.colCAngle.Name = "colCAngle"
        Me.colCAngle.ReadOnly = True
        '
        'colRawCyl
        '
        Me.colRawCyl.HeaderText = "Cylinder ADC"
        Me.colRawCyl.Name = "colRawCyl"
        Me.colRawCyl.ReadOnly = True
        '
        'colRawSC
        '
        Me.colRawSC.HeaderText = "Steam Chest ADC"
        Me.colRawSC.Name = "colRawSC"
        Me.colRawSC.ReadOnly = True
        Me.colRawSC.Width = 130
        '
        'colCylP
        '
        Me.colCylP.HeaderText = "Cylinder Pressure"
        Me.colCylP.Name = "colCylP"
        Me.colCylP.ReadOnly = True
        '
        'colSCP
        '
        Me.colSCP.HeaderText = "Steam Chest Pressure"
        Me.colSCP.Name = "colSCP"
        Me.colSCP.ReadOnly = True
        Me.colSCP.Width = 130
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Measurements returned by Uno and calculated pressures."
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(327, 63)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(157, 39)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save to CSV File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(152, 63)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(99, 39)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 692)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvData)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmData"
        Me.Text = "Measurement Data"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents colCAngle As DataGridViewTextBoxColumn
    Friend WithEvents colRawCyl As DataGridViewTextBoxColumn
    Friend WithEvents colRawSC As DataGridViewTextBoxColumn
    Friend WithEvents colCylP As DataGridViewTextBoxColumn
    Friend WithEvents colSCP As DataGridViewTextBoxColumn
End Class
