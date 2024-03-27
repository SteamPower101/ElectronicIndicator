<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblDFactorClear = New System.Windows.Forms.Label()
        Me.lblBoilerState = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblWaterUse = New System.Windows.Forms.Label()
        Me.lblWaterRate = New System.Windows.Forms.Label()
        Me.lblIHP = New System.Windows.Forms.Label()
        Me.lblWorkPerCycle = New System.Windows.Forms.Label()
        Me.lblIMEP = New System.Windows.Forms.Label()
        Me.lblEngineSpeed = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Engine Indicator Test Report"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(32, 37)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(75, 20)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "date time"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(130, 76)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(459, 89)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "description here"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(32, 57)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(70, 20)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "title here"
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderlineWidth = 2
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Enabled = False
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(125, 182)
        Me.Chart1.Name = "Chart1"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series5.Legend = "Legend1"
        Series5.MarkerColor = System.Drawing.Color.Black
        Series5.MarkerSize = 4
        Series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series5.Name = "Series1"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series6.Legend = "Legend1"
        Series6.MarkerColor = System.Drawing.Color.Black
        Series6.MarkerSize = 4
        Series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square
        Series6.Name = "Series2"
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(464, 349)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        '
        'lblDFactorClear
        '
        Me.lblDFactorClear.AutoSize = True
        Me.lblDFactorClear.Location = New System.Drawing.Point(178, 809)
        Me.lblDFactorClear.Name = "lblDFactorClear"
        Me.lblDFactorClear.Size = New System.Drawing.Size(132, 20)
        Me.lblDFactorClear.TabIndex = 24
        Me.lblDFactorClear.Text = "Diagram Factor ="
        '
        'lblBoilerState
        '
        Me.lblBoilerState.AutoSize = True
        Me.lblBoilerState.Location = New System.Drawing.Point(178, 789)
        Me.lblBoilerState.Name = "lblBoilerState"
        Me.lblBoilerState.Size = New System.Drawing.Size(118, 20)
        Me.lblBoilerState.TabIndex = 19
        Me.lblBoilerState.Text = "Boiler Steam at"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(397, 671)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "* Single Acting, Per Cylinder"
        '
        'lblWaterUse
        '
        Me.lblWaterUse.AutoSize = True
        Me.lblWaterUse.Location = New System.Drawing.Point(149, 737)
        Me.lblWaterUse.Name = "lblWaterUse"
        Me.lblWaterUse.Size = New System.Drawing.Size(91, 20)
        Me.lblWaterUse.TabIndex = 12
        Me.lblWaterUse.Text = "Water Use*"
        '
        'lblWaterRate
        '
        Me.lblWaterRate.AutoSize = True
        Me.lblWaterRate.Location = New System.Drawing.Point(149, 717)
        Me.lblWaterRate.Name = "lblWaterRate"
        Me.lblWaterRate.Size = New System.Drawing.Size(91, 20)
        Me.lblWaterRate.TabIndex = 9
        Me.lblWaterRate.Text = "Water Rate"
        '
        'lblIHP
        '
        Me.lblIHP.AutoSize = True
        Me.lblIHP.Location = New System.Drawing.Point(149, 642)
        Me.lblIHP.Name = "lblIHP"
        Me.lblIHP.Size = New System.Drawing.Size(193, 20)
        Me.lblIHP.TabIndex = 6
        Me.lblIHP.Text = "Indicated Cylinder Power:*"
        '
        'lblWorkPerCycle
        '
        Me.lblWorkPerCycle.AutoSize = True
        Me.lblWorkPerCycle.Location = New System.Drawing.Point(149, 622)
        Me.lblWorkPerCycle.Name = "lblWorkPerCycle"
        Me.lblWorkPerCycle.Size = New System.Drawing.Size(125, 20)
        Me.lblWorkPerCycle.TabIndex = 4
        Me.lblWorkPerCycle.Text = "Work per Cycle:*"
        '
        'lblIMEP
        '
        Me.lblIMEP.AutoSize = True
        Me.lblIMEP.Location = New System.Drawing.Point(149, 602)
        Me.lblIMEP.Name = "lblIMEP"
        Me.lblIMEP.Size = New System.Drawing.Size(200, 20)
        Me.lblIMEP.TabIndex = 2
        Me.lblIMEP.Text = "Indicated Mean Eff. Press.:"
        '
        'lblEngineSpeed
        '
        Me.lblEngineSpeed.AutoSize = True
        Me.lblEngineSpeed.Location = New System.Drawing.Point(149, 582)
        Me.lblEngineSpeed.Name = "lblEngineSpeed"
        Me.lblEngineSpeed.Size = New System.Drawing.Size(114, 20)
        Me.lblEngineSpeed.TabIndex = 0
        Me.lblEngineSpeed.Text = "Engine Speed:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(126, 562)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 20)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Calculations"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(126, 697)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 20)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Estimates"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(149, 769)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 20)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Assuming"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Description:"
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 851)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblDFactorClear)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lblBoilerState)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblWaterUse)
        Me.Controls.Add(Me.lblWaterRate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblIHP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEngineSpeed)
        Me.Controls.Add(Me.lblWorkPerCycle)
        Me.Controls.Add(Me.lblIMEP)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents lblDFactorClear As Label
    Friend WithEvents lblBoilerState As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblWaterUse As Label
    Friend WithEvents lblWaterRate As Label
    Friend WithEvents lblIHP As Label
    Friend WithEvents lblWorkPerCycle As Label
    Friend WithEvents lblIMEP As Label
    Friend WithEvents lblEngineSpeed As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label2 As Label
End Class
