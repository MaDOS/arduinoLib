using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Text;

namespace arduinoLib
{
    public class arduino
    {
        public SerialPort ComPort
        {
            get;
            private set;
        }

        public int DigitalPinCount
        {
            get;
            internal set;
        }

        public int AnalogPinCount
        {
            get;
            internal set;
        }

        public arduino(string comPort, int digitalPinCount, int analogPinCount)
        {
            this.ComPort = new SerialPort(comPort, 115200, Parity.None, 8);
            this.ComPort.Open();
            this.DigitalPinCount = digitalPinCount;
            this.AnalogPinCount = analogPinCount;
        }

        public virtual void digitalWrite(pin p, digitalState state)
        {
            throw new NotImplementedException();
        }

        public virtual void analogWrite(pin p, int value)
        {
            throw new NotImplementedException();
        }

        public virtual digitalState digitalRead(pin p)
        {
            throw new NotImplementedException();
        }

        public virtual int analogRead(pin p)
        {
            throw new NotImplementedException();
        }

        public enum digitalState
        {
            LOW,
            HIGH
        }
    }
}
