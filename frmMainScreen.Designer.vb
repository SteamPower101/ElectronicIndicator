<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenADataFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveMeasurementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeasDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogPlotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblComStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusErrorMsg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnContinuous = New System.Windows.Forms.Button()
        Me.btnAvgRevs = New System.Windows.Forms.Button()
        Me.btnOneRev = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCalcHP = New System.Windows.Forms.TextBox()
        Me.txtCalcIMEP = New System.Windows.Forms.TextBox()
        Me.txtCalcWork = New System.Windows.Forms.TextBox()
        Me.lblDFactor = New System.Windows.Forms.Label()
        Me.txtCalcRPM = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblBoilerState = New System.Windows.Forms.Label()
        Me.lblClearance = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCalcWaterUse = New System.Windows.Forms.TextBox()
        Me.txtCalcWaterRate = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblUnitWaterUse = New System.Windows.Forms.Label()
        Me.lblUnitWaterRate = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblUnitPower = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUnitMEP = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUnitWork = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtTestTitle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderlineWidth = 2
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(511, 119)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Black
        Series1.MarkerSize = 4
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Legend = "Legend1"
        Series2.MarkerColor = System.Drawing.Color.Black
        Series2.MarkerSize = 4
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square
        Series2.Name = "Series2"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(464, 392)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.MeasDataToolStripMenuItem, Me.LogPlotToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(989, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenADataFileToolStripMenuItem, Me.SaveMeasurementsToolStripMenuItem, Me.SaveReportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenADataFileToolStripMenuItem
        '
        Me.OpenADataFileToolStripMenuItem.Name = "OpenADataFileToolStripMenuItem"
        Me.OpenADataFileToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.OpenADataFileToolStripMenuItem.Text = "Open a Data File"
        '
        'SaveMeasurementsToolStripMenuItem
        '
        Me.SaveMeasurementsToolStripMenuItem.Name = "SaveMeasurementsToolStripMenuItem"
        Me.SaveMeasurementsToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.SaveMeasurementsToolStripMenuItem.Text = "Save Measurements"
        '
        'SaveReportToolStripMenuItem
        '
        Me.SaveReportToolStripMenuItem.Name = "SaveReportToolStripMenuItem"
        Me.SaveReportToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.SaveReportToolStripMenuItem.Text = "Save Report"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(78, 25)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        Me.SettingsToolStripMenuItem.ToolTipText = "Change measurement settings."
        '
        'MeasDataToolStripMenuItem
        '
        Me.MeasDataToolStripMenuItem.Name = "MeasDataToolStripMenuItem"
        Me.MeasDataToolStripMenuItem.Size = New System.Drawing.Size(125, 25)
        Me.MeasDataToolStripMenuItem.Text = "Measurements"
        Me.MeasDataToolStripMenuItem.ToolTipText = "View the last set of measurments taken."
        '
        'LogPlotToolStripMenuItem
        '
        Me.LogPlotToolStripMenuItem.Name = "LogPlotToolStripMenuItem"
        Me.LogPlotToolStripMenuItem.Size = New System.Drawing.Size(79, 25)
        Me.LogPlotToolStripMenuItem.Text = "Log Plot"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel1, Me.lblComStatus, Me.lblStatusErrorMsg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 581)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(989, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel1
        '
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(118, 21)
        Me.StatusLabel1.Text = "Ardunio Uno is "
        '
        'lblComStatus
        '
        Me.lblComStatus.BackColor = System.Drawing.Color.Red
        Me.lblComStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComStatus.Name = "lblComStatus"
        Me.lblComStatus.Size = New System.Drawing.Size(129, 21)
        Me.lblComStatus.Text = "NOT Connected"
        '
        'lblStatusErrorMsg
        '
        Me.lblStatusErrorMsg.BackColor = System.Drawing.Color.Red
        Me.lblStatusErrorMsg.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblStatusErrorMsg.Name = "lblStatusErrorMsg"
        Me.lblStatusErrorMsg.Size = New System.Drawing.Size(110, 21)
        Me.lblStatusErrorMsg.Text = "error message"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.btnContinuous)
        Me.GroupBox1.Controls.Add(Me.btnAvgRevs)
        Me.GroupBox1.Controls.Add(Me.btnOneRev)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(511, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 74)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Take Measurements"
        '
        'btnContinuous
        '
        Me.btnContinuous.Location = New System.Drawing.Point(303, 25)
        Me.btnContinuous.Name = "btnContinuous"
        Me.btnContinuous.Size = New System.Drawing.Size(143, 39)
        Me.btnContinuous.TabIndex = 2
        Me.btnContinuous.Text = "Continuous"
        Me.btnContinuous.UseVisualStyleBackColor = True
        '
        'btnAvgRevs
        '
        Me.btnAvgRevs.Location = New System.Drawing.Point(154, 25)
        Me.btnAvgRevs.Name = "btnAvgRevs"
        Me.btnAvgRevs.Size = New System.Drawing.Size(143, 39)
        Me.btnAvgRevs.TabIndex = 1
        Me.btnAvgRevs.Text = "Average N Revs"
        Me.btnAvgRevs.UseVisualStyleBackColor = True
        '
        'btnOneRev
        '
        Me.btnOneRev.Location = New System.Drawing.Point(5, 25)
        Me.btnOneRev.Name = "btnOneRev"
        Me.btnOneRev.Size = New System.Drawing.Size(143, 39)
        Me.btnOneRev.TabIndex = 0
        Me.btnOneRev.Text = "One Revolution"
        Me.btnOneRev.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.txtCalcHP)
        Me.GroupBox2.Controls.Add(Me.txtCalcIMEP)
        Me.GroupBox2.Controls.Add(Me.txtCalcWork)
        Me.GroupBox2.Controls.Add(Me.lblDFactor)
        Me.GroupBox2.Controls.Add(Me.txtCalcRPM)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.lblUnitPower)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblUnitMEP)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblUnitWork)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 306)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results"
        '
        'txtCalcHP
        '
        Me.txtCalcHP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCalcHP.Location = New System.Drawing.Point(216, 155)
        Me.txtCalcHP.Name = "txtCalcHP"
        Me.txtCalcHP.ReadOnly = True
        Me.txtCalcHP.Size = New System.Drawing.Size(82, 26)
        Me.txtCalcHP.TabIndex = 16
        Me.txtCalcHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCalcIMEP
        '
        Me.txtCalcIMEP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCalcIMEP.Location = New System.Drawing.Point(216, 61)
        Me.txtCalcIMEP.Name = "txtCalcIMEP"
        Me.txtCalcIMEP.ReadOnly = True
        Me.txtCalcIMEP.Size = New System.Drawing.Size(82, 26)
        Me.txtCalcIMEP.TabIndex = 14
        Me.txtCalcIMEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCalcWork
        '
        Me.txtCalcWork.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCalcWork.Location = New System.Drawing.Point(216, 126)
        Me.txtCalcWork.Name = "txtCalcWork"
        Me.txtCalcWork.ReadOnly = True
        Me.txtCalcWork.Size = New System.Drawing.Size(82, 26)
        Me.txtCalcWork.TabIndex = 15
        Me.txtCalcWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDFactor
        '
        Me.lblDFactor.AutoSize = True
        Me.lblDFactor.Location = New System.Drawing.Point(246, 103)
        Me.lblDFactor.Name = "lblDFactor"
        Me.lblDFactor.Size = New System.Drawing.Size(41, 20)
        Me.lblDFactor.TabIndex = 25
        Me.lblDFactor.Text = "80%"
        '
        'txtCalcRPM
        '
        Me.txtCalcRPM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCalcRPM.Location = New System.Drawing.Point(216, 31)
        Me.txtCalcRPM.Name = "txtCalcRPM"
        Me.txtCalcRPM.ReadOnly = True
        Me.txtCalcRPM.Size = New System.Drawing.Size(82, 26)
        Me.txtCalcRPM.TabIndex = 13
        Me.txtCalcRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(228, 20)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Assuming a Diagram Factor of:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblBoilerState)
        Me.GroupBox4.Controls.Add(Me.lblClearance)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtCalcWaterUse)
        Me.GroupBox4.Controls.Add(Me.txtCalcWaterRate)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.lblUnitWaterUse)
        Me.GroupBox4.Controls.Add(Me.lblUnitWaterRate)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 189)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(429, 111)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Estimates"
        '
        'lblBoilerState
        '
        Me.lblBoilerState.AutoSize = True
        Me.lblBoilerState.Location = New System.Drawing.Point(132, 22)
        Me.lblBoilerState.Name = "lblBoilerState"
        Me.lblBoilerState.Size = New System.Drawing.Size(36, 20)
        Me.lblBoilerState.TabIndex = 20
        Me.lblBoilerState.Text = "800"
        '
        'lblClearance
        '
        Me.lblClearance.AutoSize = True
        Me.lblClearance.Location = New System.Drawing.Point(378, 22)
        Me.lblClearance.Name = "lblClearance"
        Me.lblClearance.Size = New System.Drawing.Size(45, 20)
        Me.lblClearance.TabIndex = 27
        Me.lblClearance.Text = "5.0%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Boiler Steam at"
        '
        'txtCalcWaterUse
        '
        Me.txtCalcWaterUse.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCalcWaterUse.Location = New System.Drawing.Point(107, 74)
        Me.txtCalcWaterUse.Name = "txtCalcWaterUse"
        Me.txtCalcWaterUse.ReadOnly = True
        Me.txtCalcWaterUse.Size = New System.Drawing.Size(63, 26)
        Me.txtCalcWaterUse.TabIndex = 18
        Me.txtCalcWaterUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCalcWaterRate
        '
        Me.txtCalcWaterRate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCalcWaterRate.Location = New System.Drawing.Point(107, 45)
        Me.txtCalcWaterRate.Name = "txtCalcWaterRate"
        Me.txtCalcWaterRate.ReadOnly = True
        Me.txtCalcWaterRate.Size = New System.Drawing.Size(63, 26)
        Me.txtCalcWaterRate.TabIndex = 17
        Me.txtCalcWaterRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(298, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 20)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Clearance:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(247, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "* Single Acting, Per Cylinder"
        '
        'lblUnitWaterUse
        '
        Me.lblUnitWaterUse.AutoSize = True
        Me.lblUnitWaterUse.Location = New System.Drawing.Point(176, 77)
        Me.lblUnitWaterUse.Name = "lblUnitWaterUse"
        Me.lblUnitWaterUse.Size = New System.Drawing.Size(57, 20)
        Me.lblUnitWaterUse.TabIndex = 14
        Me.lblUnitWaterUse.Text = "LB/HR"
        '
        'lblUnitWaterRate
        '
        Me.lblUnitWaterRate.AutoSize = True
        Me.lblUnitWaterRate.Location = New System.Drawing.Point(176, 48)
        Me.lblUnitWaterRate.Name = "lblUnitWaterRate"
        Me.lblUnitWaterRate.Size = New System.Drawing.Size(84, 20)
        Me.lblUnitWaterRate.TabIndex = 13
        Me.lblUnitWaterRate.Text = "LB/HP-HR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 20)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Water Use*:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Water Rate:"
        '
        'lblUnitPower
        '
        Me.lblUnitPower.AutoSize = True
        Me.lblUnitPower.Location = New System.Drawing.Point(304, 158)
        Me.lblUnitPower.Name = "lblUnitPower"
        Me.lblUnitPower.Size = New System.Drawing.Size(31, 20)
        Me.lblUnitPower.TabIndex = 7
        Me.lblUnitPower.Text = "HP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "RPM"
        '
        'lblUnitMEP
        '
        Me.lblUnitMEP.AutoSize = True
        Me.lblUnitMEP.Location = New System.Drawing.Point(304, 64)
        Me.lblUnitMEP.Name = "lblUnitMEP"
        Me.lblUnitMEP.Size = New System.Drawing.Size(48, 20)
        Me.lblUnitMEP.TabIndex = 3
        Me.lblUnitMEP.Text = "PSIG"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cylinder Power*:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Indicated Mean Eff. Press.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Work per Cycle*:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Engine Speed:"
        '
        'lblUnitWork
        '
        Me.lblUnitWork.AutoSize = True
        Me.lblUnitWork.Location = New System.Drawing.Point(304, 129)
        Me.lblUnitWork.Name = "lblUnitWork"
        Me.lblUnitWork.Size = New System.Drawing.Size(64, 20)
        Me.lblUnitWork.TabIndex = 5
        Me.lblUnitWork.Text = "FT-LBS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtDescription)
        Me.GroupBox3.Controls.Add(Me.txtTestTitle)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(447, 216)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Test Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "(400 characters maximum)"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(13, 81)
        Me.txtDescription.MaxLength = 400
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(423, 129)
        Me.txtDescription.TabIndex = 3
        '
        'txtTestTitle
        '
        Me.txtTestTitle.Location = New System.Drawing.Point(57, 27)
        Me.txtTestTitle.MaxLength = 80
        Me.txtTestTitle.Name = "txtTestTitle"
        Me.txtTestTitle.Size = New System.Drawing.Size(380, 26)
        Me.txtTestTitle.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Title"
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 607)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainScreen"
        Me.Text = "SACA Electronic Engine Indicator"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenADataFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveMeasurementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MeasDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblComStatus As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOneRev As Button
    Friend WithEvents btnContinuous As Button
    Friend WithEvents btnAvgRevs As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblUnitPower As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblUnitWork As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUnitMEP As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtTestTitle As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblUnitWaterRate As Label
    Friend WithEvents txtCalcHP As TextBox
    Friend WithEvents txtCalcWork As TextBox
    Friend WithEvents txtCalcIMEP As TextBox
    Friend WithEvents txtCalcRPM As TextBox
    Friend WithEvents txtCalcWaterUse As TextBox
    Friend WithEvents txtCalcWaterRate As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblUnitWaterUse As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStatusErrorMsg As ToolStripStatusLabel
    Friend WithEvents Label17 As Label
    Friend WithEvents lblBoilerState As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblClearance As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblDFactor As Label
    Friend WithEvents LogPlotToolStripMenuItem As ToolStripMenuItem
End Class
