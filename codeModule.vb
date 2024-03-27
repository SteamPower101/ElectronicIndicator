Option Explicit On
Option Strict On
Imports System.Diagnostics.Contracts
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting
'
'
' Internally, the program works in units of psig, inches

Enum PUnits     ' these are used for tranducer calibration points
    PSIG
    PSIA
    BarG
    BarA
    MPaG
    MPaA
End Enum
Module codeModule


    ' Global Variables
    '
    ' units are either inches/PSIG/HP or mm/BarG/kW (i.e., metric)
    Public flgMetric As Boolean = False

    ' strings for the units to display; I = Imperial, M = Metric.
    Public Const strIUnit_P As String = " psig"  ' pressure
    Public Const strMUnit_P As String = " BarG"
    Public Const strIUnit_L As String = " inch"  ' length
    Public Const strMUnit_L As String = " mm"
    Public Const strIUnit_T As String = " °F"    ' temp
    Public Const strMUnit_T As String = " °C"
    Public Const strIUnit_Pow As String = " HP"  ' power
    Public Const strMUnit_Pow As String = " kW"
    Public Const strIUnit_W As String = " ft-lb" ' work
    Public Const strMUnit_W As String = " N-m"
    Public Const strIUnit_WR As String = " lb/HP-hr" ' water rate
    Public Const strMUnit_WR As String = " kg/kW-hr"
    Public Const strIUnit_WU As String = " lb/hr" ' water use
    Public Const strMUnit_WU As String = " kg/hr"
    ' conversion constants
    Public Const atmPsia As Double = 14.696
    Public Const psiPerBar As Double = 14.5038
    Public Const NmPerFtLb As Double = 1.3558
    Public Const kWPerHP As Double = 0.7457
    Public Const KgHrPerLbHr As Double = 0.4536
    Public Const KgKwHrPerLbHPHr As Double = KgHrPerLbHr * kWPerHP




    Public testTitle As String = ""             ' user entered title
    Public testDescription As String = ""

    ' Hardware Settings
    Public bore As Double = 1.0   ' cylinder bore
    Public stroke As Double = 1.0 ' cylinder stroke
    Public conrod As Double = 2.0 ' length of connecting rod

    Public encoderPPR As Integer = 5    ' rotary encoder pulses/rev
    Public averageReadings As Integer = 10      ' how many readings to average

    Public dFactor As Double = 0.8      ' diagram factor
    Public clearance As Double = 0.05   ' cylinder clearance

    ' pressure transducer calibration values, Cyl = cylinder, SC = steam chest
    ' these calibration pressure units are given by the user
    Public Cyl_PUnits As PUnits = PUnits.PSIG
    Public Cyl_lowP As Double = 0.0   ' low pressure calibration point
    Public Cyl_lowV As Double = 0.5   ' voltage at this point
    Public Cyl_hiP As Double = 100.0  ' high pressure calibration point
    Public Cyl_hiV As Double = 4.5

    Public flgMeasureSC As Boolean = False   ' true if measuring steam chest pressure
    Public SC_PUnits As PUnits = PUnits.PSIG
    Public SC_lowP As Double = 0.0    ' SC sensor cal data
    Public SC_lowV As Double = 0.5
    Public SC_hiP As Double = 100.0
    Public SC_hiV As Double = 4.5
    ' these calibration pressure units are in psig and used in calculations
    Public Cyl_lowPpsig As Double
    Public Cyl_hiPpsig As Double
    Public SC_lowPpsig As Double
    Public SC_hiPpsig As Double

    Public boilerPress As Double = 100          ' used for water rate estimate
    Public boilerTemp As Double = 500
    Public flgBoilerSaturated As Boolean = False   ' if true, use saturation temp for given pressure

    Public Const SettingsFN As String = "EngineIndicatorApp.set"
    Public Const AppVersion As String = "1.0"

    Public UnoPort As New IO.Ports.SerialPort
    Public Const longTimeout As Integer = 10000  ' wait for measurements to finish
    Public Const shortTimeout As Integer = 200   ' normal serial timeout
    Public flgUnoConnected As Boolean = False
    Public flgUnoBusy As Boolean = False

    ' variables for measurement data
    Const MAXDATA As Integer = 400
    Public rawCylReadings(MAXDATA) As Integer   ' ADC counts from Uno
    Public rawSCReadings(MAXDATA) As Integer
    Public Cyl_psig(MAXDATA) As Double          ' calculated pressure values
    Public SC_psig(MAXDATA) As Double
    Public PistonPosition(MAXDATA) As Double    ' calculated position, 0 (TDC) to 1 (BDC)
    Public nMeasuredPts As Integer              ' # data points from Uno
    Public cyclesToMeasure As Integer           ' number of cycles measured for averaging

    ' values calculated from test
    Public engineRPM As Double = 2500
    Public IMEP_psig As Double
    Public iWorkPerCycle_ftlb As Double
    Public iPower_hp As Double
    Public waterRate_lbhphr As Double
    Public waterUse_lbhr As Double




    Sub Setup()

        UnoHasDisonnected() ' set UI to disconnected state
        GetSettings()      ' settings from last run
        frmMainScreen.txtTestTitle.Text = testTitle
        frmMainScreen.txtDescription.Text = testDescription
        ' put the number in the Average button text
        frmMainScreen.btnAvgRevs.Text = "Average " & averageReadings.ToString & " Revs"

        ' Set our serial port parameters
        UnoPort.BaudRate = 115200
        UnoPort.DataBits = 8
        UnoPort.Parity = IO.Ports.Parity.None
        UnoPort.StopBits = IO.Ports.StopBits.One
        UnoPort.Handshake = IO.Ports.Handshake.None
        UnoPort.Encoding = System.Text.Encoding.Default
        UnoPort.ReadTimeout = shortTimeout
        UnoPort.WriteTimeout = shortTimeout



    End Sub

End Module
