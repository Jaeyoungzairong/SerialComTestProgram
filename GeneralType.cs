using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialComTESTProgram
{
    public enum PortNo
    {
        COM1,
        COM2,
        COM3,
        COM4,
        COM5,
        COM6,
        COM7,
        COM8,
        COM9,
        COM10,
        COM11,
        COM12,
        COM13,
        COM14,
        COM15,
        COM16,
        COM17,
        COM18,
        COM19,
        COM20
    }
    public enum BaudRate : int
    {
        _4800 = 4800,
        _9600 = 9600,
        _19800 = 19800,
        _34000 = 34000
    }
    public enum DataBit : int
    {
        _7 = 7,
        _8 = 8
    }
    public enum StopBit
    {
        One,
        OnePointFive,
        Two
    }
    public enum Paritys
    {
        None,
        Odd,
        Even
    }
    public enum SectionList
    {
        COMPORT,
        TCPPORT,
        COMMAND,
        TIMER,
    }

    public enum ComPortList
    {
        PORTNAME,
        BAUDRATE,
        DATABITS, 
        PARITY, 
        STOPBITS
    }

    public enum CommandList
    {
        TEMP2000, 
        TEMP2000INFO,
        BACKLIGHTON,
        BACKLIGHTOFF,
        LOADCELL, 
        SDC15,
        CWLASER
    }

    public enum TimerList
    {
        INTERVAL
    }
    public enum TCPPortList
    {
        ADDRESS,
        PORTNUM
    }
    public enum Use
    {
        Use,
        NoUse
    }
}
