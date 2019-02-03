using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WS2812b
{
    public class Config
    {
            public int MaxLEDs {get; set; }
            public int ArduinoPin {get; set;}
            public int ComPort {get; set;}
            public int StartSeg0 { get; set;}
            public int EndsSeg0{ get; set;}





    }
}
