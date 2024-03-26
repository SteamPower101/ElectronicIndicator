# Electronic Engine Indicator

An electronic engine indicator for creating P-V diagrams and calculating engine indicated performance measures.

This version was made for reciprocating Rankine cycle expanders, i.e., steam engines.  

Data acquisition is done with an Arduino Uno communicating with a Windows PC over the USB serial port.  The Atmega328 ADC is used to digitize voltage signals from pressure transducers.  Two pressure channels are provided: one for cylinder pressure and the other for steam chest pressure.  A rotary encoder connected to the engine crankshaft provides timing pulses to trigger readings.

The PC program is written in Visual Basic using .NET Framework 4.8.  It controls the data acquisition and creates indicator diagrams, log-log PV diagrams, engine speed variation diagram and calculates IMEP, IHP and water rate, among other values.


