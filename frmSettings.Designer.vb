<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMetric = New System.Windows.Forms.RadioButton()
        Me.radImperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblSCUnit = New System.Windows.Forms.Label()
        Me.txtSCHiV = New System.Windows.Forms.TextBox()
        Me.txtSCHiP = New System.Windows.Forms.TextBox()
        Me.txtSCLoV = New System.Windows.Forms.TextBox()
        Me.txtSCLoP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxSCUnit = New System.Windows.Forms.ComboBox()
        Me.chkSChest = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblCylUnit = New System.Windows.Forms.Label()
        Me.txtCylHiV = New System.Windows.Forms.TextBox()
        Me.txtCylHiP = New System.Windows.Forms.TextBox()
        Me.txtCylLoV = New System.Windows.Forms.TextBox()
        Me.txtCylLoP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxCylUnit = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtPPR = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtConrod = New System.Windows.Forms.TextBox()
        Me.txtStroke = New System.Windows.Forms.TextBox()
        Me.txtBore = New System.Windows.Forms.TextBox()
        Me.lblLength3 = New System.Windows.Forms.Label()
        Me.lblLength2 = New System.Windows.Forms.Label()
        Me.lblLength1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtBTemp = New System.Windows.Forms.TextBox()
        Me.txtBPress = New System.Windows.Forms.TextBox()
        Me.lblBTemp = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkBSaturated = New System.Windows.Forms.CheckBox()
        Me.lblBPress = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtAvg = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.nudClearance = New System.Windows.Forms.NumericUpDown()
        Me.nudDFactor = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.nudClearance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.radMetric)
        Me.GroupBox1.Controls.Add(Me.radImperial)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(186, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Units"
        '
        'radMetric
        '
        Me.radMetric.AutoSize = True
        Me.radMetric.Location = New System.Drawing.Point(10, 49)
        Me.radMetric.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radMetric.Name = "radMetric"
        Me.radMetric.Size = New System.Drawing.Size(154, 24)
        Me.radMetric.TabIndex = 1
        Me.radMetric.Text = "BarG, mm, kW, °C"
        Me.radMetric.UseVisualStyleBackColor = True
        '
        'radImperial
        '
        Me.radImperial.AutoSize = True
        Me.radImperial.Checked = True
        Me.radImperial.Location = New System.Drawing.Point(10, 26)
        Me.radImperial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radImperial.Name = "radImperial"
        Me.radImperial.Size = New System.Drawing.Size(175, 24)
        Me.radImperial.TabIndex = 0
        Me.radImperial.TabStop = True
        Me.radImperial.Text = "PSIG, Inches, HP, °F"
        Me.radImperial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 109)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(581, 228)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pressure Transducers"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 56)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 20)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Calibration Data"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblSCUnit)
        Me.GroupBox4.Controls.Add(Me.txtSCHiV)
        Me.GroupBox4.Controls.Add(Me.txtSCHiP)
        Me.GroupBox4.Controls.Add(Me.txtSCLoV)
        Me.GroupBox4.Controls.Add(Me.txtSCLoP)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.cbxSCUnit)
        Me.GroupBox4.Controls.Add(Me.chkSChest)
        Me.GroupBox4.Location = New System.Drawing.Point(361, 29)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(210, 190)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Steam Chest Transducer"
        '
        'lblSCUnit
        '
        Me.lblSCUnit.AutoSize = True
        Me.lblSCUnit.Location = New System.Drawing.Point(93, 130)
        Me.lblSCUnit.Name = "lblSCUnit"
        Me.lblSCUnit.Size = New System.Drawing.Size(35, 20)
        Me.lblSCUnit.TabIndex = 32
        Me.lblSCUnit.Text = "unit"
        '
        'txtSCHiV
        '
        Me.txtSCHiV.Location = New System.Drawing.Point(9, 159)
        Me.txtSCHiV.Name = "txtSCHiV"
        Me.txtSCHiV.Size = New System.Drawing.Size(77, 26)
        Me.txtSCHiV.TabIndex = 31
        '
        'txtSCHiP
        '
        Me.txtSCHiP.Location = New System.Drawing.Point(9, 127)
        Me.txtSCHiP.Name = "txtSCHiP"
        Me.txtSCHiP.Size = New System.Drawing.Size(77, 26)
        Me.txtSCHiP.TabIndex = 30
        '
        'txtSCLoV
        '
        Me.txtSCLoV.Location = New System.Drawing.Point(9, 95)
        Me.txtSCLoV.Name = "txtSCLoV"
        Me.txtSCLoV.Size = New System.Drawing.Size(77, 26)
        Me.txtSCLoV.TabIndex = 29
        '
        'txtSCLoP
        '
        Me.txtSCLoP.ForeColor = System.Drawing.Color.Silver
        Me.txtSCLoP.Location = New System.Drawing.Point(9, 63)
        Me.txtSCLoP.Name = "txtSCLoP"
        Me.txtSCLoP.Size = New System.Drawing.Size(77, 26)
        Me.txtSCLoP.TabIndex = 28
        Me.txtSCLoP.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 162)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Volts"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(93, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Volts"
        '
        'cbxSCUnit
        '
        Me.cbxSCUnit.FormattingEnabled = True
        Me.cbxSCUnit.Location = New System.Drawing.Point(93, 61)
        Me.cbxSCUnit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxSCUnit.Name = "cbxSCUnit"
        Me.cbxSCUnit.Size = New System.Drawing.Size(64, 28)
        Me.cbxSCUnit.TabIndex = 24
        '
        'chkSChest
        '
        Me.chkSChest.AutoSize = True
        Me.chkSChest.Location = New System.Drawing.Point(9, 29)
        Me.chkSChest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSChest.Name = "chkSChest"
        Me.chkSChest.Size = New System.Drawing.Size(195, 24)
        Me.chkSChest.TabIndex = 0
        Me.chkSChest.Text = "Enable This Transducer"
        Me.chkSChest.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCylUnit)
        Me.GroupBox3.Controls.Add(Me.txtCylHiV)
        Me.GroupBox3.Controls.Add(Me.txtCylHiP)
        Me.GroupBox3.Controls.Add(Me.txtCylLoV)
        Me.GroupBox3.Controls.Add(Me.txtCylLoP)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbxCylUnit)
        Me.GroupBox3.Location = New System.Drawing.Point(189, 29)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(164, 190)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cylinder Transducer"
        '
        'lblCylUnit
        '
        Me.lblCylUnit.AutoSize = True
        Me.lblCylUnit.Location = New System.Drawing.Point(91, 128)
        Me.lblCylUnit.Name = "lblCylUnit"
        Me.lblCylUnit.Size = New System.Drawing.Size(35, 20)
        Me.lblCylUnit.TabIndex = 24
        Me.lblCylUnit.Text = "unit"
        '
        'txtCylHiV
        '
        Me.txtCylHiV.Location = New System.Drawing.Point(7, 157)
        Me.txtCylHiV.Name = "txtCylHiV"
        Me.txtCylHiV.Size = New System.Drawing.Size(77, 26)
        Me.txtCylHiV.TabIndex = 23
        '
        'txtCylHiP
        '
        Me.txtCylHiP.Location = New System.Drawing.Point(7, 125)
        Me.txtCylHiP.Name = "txtCylHiP"
        Me.txtCylHiP.Size = New System.Drawing.Size(77, 26)
        Me.txtCylHiP.TabIndex = 22
        '
        'txtCylLoV
        '
        Me.txtCylLoV.Location = New System.Drawing.Point(7, 93)
        Me.txtCylLoV.Name = "txtCylLoV"
        Me.txtCylLoV.Size = New System.Drawing.Size(77, 26)
        Me.txtCylLoV.TabIndex = 21
        '
        'txtCylLoP
        '
        Me.txtCylLoP.Location = New System.Drawing.Point(7, 61)
        Me.txtCylLoP.Name = "txtCylLoP"
        Me.txtCylLoP.Size = New System.Drawing.Size(77, 26)
        Me.txtCylLoP.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 160)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Volts"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Volts"
        '
        'cbxCylUnit
        '
        Me.cbxCylUnit.FormattingEnabled = True
        Me.cbxCylUnit.Location = New System.Drawing.Point(91, 59)
        Me.cbxCylUnit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxCylUnit.Name = "cbxCylUnit"
        Me.cbxCylUnit.Size = New System.Drawing.Size(64, 28)
        Me.cbxCylUnit.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 189)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "High Voltage Value:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "High Pressure Point:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 125)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Low Voltage Value:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Low Pressure Point:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox5.Controls.Add(Me.txtPPR)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Location = New System.Drawing.Point(207, 14)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Size = New System.Drawing.Size(184, 84)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rotary Encoder"
        '
        'txtPPR
        '
        Me.txtPPR.Location = New System.Drawing.Point(56, 46)
        Me.txtPPR.Name = "txtPPR"
        Me.txtPPR.Size = New System.Drawing.Size(77, 26)
        Me.txtPPR.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 24)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Pulses Per Revolution:"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox6.Controls.Add(Me.txtConrod)
        Me.GroupBox6.Controls.Add(Me.txtStroke)
        Me.GroupBox6.Controls.Add(Me.txtBore)
        Me.GroupBox6.Controls.Add(Me.lblLength3)
        Me.GroupBox6.Controls.Add(Me.lblLength2)
        Me.GroupBox6.Controls.Add(Me.lblLength1)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 347)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox6.Size = New System.Drawing.Size(281, 134)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cylinder Data"
        '
        'txtConrod
        '
        Me.txtConrod.Location = New System.Drawing.Point(141, 93)
        Me.txtConrod.Name = "txtConrod"
        Me.txtConrod.Size = New System.Drawing.Size(77, 26)
        Me.txtConrod.TabIndex = 20
        '
        'txtStroke
        '
        Me.txtStroke.Location = New System.Drawing.Point(141, 61)
        Me.txtStroke.Name = "txtStroke"
        Me.txtStroke.Size = New System.Drawing.Size(77, 26)
        Me.txtStroke.TabIndex = 19
        '
        'txtBore
        '
        Me.txtBore.Location = New System.Drawing.Point(141, 29)
        Me.txtBore.Name = "txtBore"
        Me.txtBore.Size = New System.Drawing.Size(77, 26)
        Me.txtBore.TabIndex = 18
        '
        'lblLength3
        '
        Me.lblLength3.AutoSize = True
        Me.lblLength3.Location = New System.Drawing.Point(225, 96)
        Me.lblLength3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLength3.Name = "lblLength3"
        Me.lblLength3.Size = New System.Drawing.Size(38, 20)
        Me.lblLength3.TabIndex = 17
        Me.lblLength3.Text = "inch"
        '
        'lblLength2
        '
        Me.lblLength2.AutoSize = True
        Me.lblLength2.Location = New System.Drawing.Point(225, 67)
        Me.lblLength2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLength2.Name = "lblLength2"
        Me.lblLength2.Size = New System.Drawing.Size(38, 20)
        Me.lblLength2.TabIndex = 16
        Me.lblLength2.Text = "inch"
        '
        'lblLength1
        '
        Me.lblLength1.AutoSize = True
        Me.lblLength1.Location = New System.Drawing.Point(225, 32)
        Me.lblLength1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLength1.Name = "lblLength1"
        Me.lblLength1.Size = New System.Drawing.Size(38, 20)
        Me.lblLength1.TabIndex = 15
        Me.lblLength1.Text = "inch"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 96)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Conrod Length:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 64)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 20)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Stroke:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 32)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Bore:"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox7.Controls.Add(Me.txtBTemp)
        Me.GroupBox7.Controls.Add(Me.txtBPress)
        Me.GroupBox7.Controls.Add(Me.lblBTemp)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.chkBSaturated)
        Me.GroupBox7.Controls.Add(Me.lblBPress)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Location = New System.Drawing.Point(301, 347)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(294, 134)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Boiler Steam Conditions"
        '
        'txtBTemp
        '
        Me.txtBTemp.Location = New System.Drawing.Point(154, 79)
        Me.txtBTemp.Name = "txtBTemp"
        Me.txtBTemp.Size = New System.Drawing.Size(77, 26)
        Me.txtBTemp.TabIndex = 20
        '
        'txtBPress
        '
        Me.txtBPress.Location = New System.Drawing.Point(135, 32)
        Me.txtBPress.Name = "txtBPress"
        Me.txtBPress.Size = New System.Drawing.Size(77, 26)
        Me.txtBPress.TabIndex = 19
        '
        'lblBTemp
        '
        Me.lblBTemp.AutoSize = True
        Me.lblBTemp.Location = New System.Drawing.Point(237, 82)
        Me.lblBTemp.Name = "lblBTemp"
        Me.lblBTemp.Size = New System.Drawing.Size(19, 20)
        Me.lblBTemp.TabIndex = 6
        Me.lblBTemp.Text = "F"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(41, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Temperature:"
        '
        'chkBSaturated
        '
        Me.chkBSaturated.AutoSize = True
        Me.chkBSaturated.Location = New System.Drawing.Point(23, 56)
        Me.chkBSaturated.Name = "chkBSaturated"
        Me.chkBSaturated.Size = New System.Drawing.Size(99, 24)
        Me.chkBSaturated.TabIndex = 3
        Me.chkBSaturated.Text = "Saturated"
        Me.chkBSaturated.UseVisualStyleBackColor = True
        '
        'lblBPress
        '
        Me.lblBPress.AutoSize = True
        Me.lblBPress.Location = New System.Drawing.Point(218, 35)
        Me.lblBPress.Name = "lblBPress"
        Me.lblBPress.Size = New System.Drawing.Size(48, 20)
        Me.lblBPress.TabIndex = 2
        Me.lblBPress.Text = "PSIG"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Pressure:"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnOK.Location = New System.Drawing.Point(429, 513)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(84, 50)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox8.Controls.Add(Me.txtAvg)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Location = New System.Drawing.Point(403, 14)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox8.Size = New System.Drawing.Size(192, 85)
        Me.GroupBox8.TabIndex = 22
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Averaging"
        '
        'txtAvg
        '
        Me.txtAvg.Location = New System.Drawing.Point(61, 47)
        Me.txtAvg.Name = "txtAvg"
        Me.txtAvg.Size = New System.Drawing.Size(77, 26)
        Me.txtAvg.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 24)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 20)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Revolutions to Average:"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox9.Controls.Add(Me.nudClearance)
        Me.GroupBox9.Controls.Add(Me.nudDFactor)
        Me.GroupBox9.Controls.Add(Me.Label19)
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.Label18)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Location = New System.Drawing.Point(14, 489)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(320, 90)
        Me.GroupBox9.TabIndex = 23
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Assumptions"
        '
        'nudClearance
        '
        Me.nudClearance.DecimalPlaces = 1
        Me.nudClearance.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudClearance.Location = New System.Drawing.Point(166, 55)
        Me.nudClearance.Name = "nudClearance"
        Me.nudClearance.Size = New System.Drawing.Size(51, 26)
        Me.nudClearance.TabIndex = 30
        Me.nudClearance.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nudDFactor
        '
        Me.nudDFactor.Location = New System.Drawing.Point(166, 20)
        Me.nudDFactor.Minimum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.nudDFactor.Name = "nudDFactor"
        Me.nudDFactor.Size = New System.Drawing.Size(51, 26)
        Me.nudDFactor.TabIndex = 24
        Me.nudDFactor.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(224, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 20)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "%"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(22, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(145, 20)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Cylinder Clearance:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(223, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 20)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "%"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 20)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Diagram Factor:"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 593)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.nudClearance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDFactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radImperial As RadioButton
    Friend WithEvents radMetric As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkSChest As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbxCylUnit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblLength3 As Label
    Friend WithEvents lblLength2 As Label
    Friend WithEvents lblLength1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblBTemp As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents chkBSaturated As CheckBox
    Friend WithEvents lblBPress As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtConrod As TextBox
    Friend WithEvents txtStroke As TextBox
    Friend WithEvents txtBore As TextBox
    Friend WithEvents txtBTemp As TextBox
    Friend WithEvents txtBPress As TextBox
    Friend WithEvents txtSCHiV As TextBox
    Friend WithEvents txtSCHiP As TextBox
    Friend WithEvents txtSCLoV As TextBox
    Friend WithEvents txtSCLoP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxSCUnit As ComboBox
    Friend WithEvents txtCylHiV As TextBox
    Friend WithEvents txtCylHiP As TextBox
    Friend WithEvents txtCylLoV As TextBox
    Friend WithEvents txtCylLoP As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents txtPPR As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents txtAvg As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblSCUnit As Label
    Friend WithEvents lblCylUnit As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents nudDFactor As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents nudClearance As NumericUpDown
End Class
