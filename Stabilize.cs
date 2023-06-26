using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stabilizer
{
    class Stabilize
    {
        private int _inputVoltage;

        public int InputVoltage
        {
            get { return _inputVoltage; }
            set { _inputVoltage = value; }
        }

        public string State;
        
        public int stabilize()
        {
            int Output=0;
            if (_inputVoltage >= 210 && _inputVoltage <= 230)
            {
               State = ReportState(States.Normal);
                Output = 220;
            }
            else if(_inputVoltage < 210)
            {
              State = ReportState(States.Low);
            }
            else if(_inputVoltage > 230)
            {
                State = ReportState(States.High);
            }
            return Output;

        }

        public string ReportState(States X) 
        {
            string str="";
            if (X == States.Low)
            {
                str = "Low Voltage!!!";
            }
            else if (X == States.High)
            {
                str = "High Voltage!!!";
            }
            else if(X == States.Normal)
            {
                str = "Normal";
            }
            return str;
        }

        public enum States 
        {
            Low,
            High,
            Normal
        }
    }

}
