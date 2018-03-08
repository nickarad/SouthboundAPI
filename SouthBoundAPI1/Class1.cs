using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthBoundAPI1
{
    //IoT
    public class IoTNode
    {
        public string Name;
        public int State;
        public string SerialNumber;
        public string Manufacturer;
        public string Firmware;
        public List<IoTThings> Things;

    }

    public class IoTThings

    {
        public string Name;
        public Functionality Funcionality;
        public string State;
        public string Manufacturer;
        public string Firmware;

    }

    public class Registration
    {
        public IoTNode Node;
    }
    public class ReportValue:Common
    {
       
    }
    public class Common
    {
        public string NodeSerialNumber;
        public string Name;
        public Functionality func;
        public string State;

    }
    public class ApiMsg
    {
        public object msg;
        public MsgType MsgType;
    }

    public enum MsgType
    {
        R,
        SV,
        UV
    }
    public class UpdateValue:Common
    {

    }

    public enum Functionality
    {
        Temparture,
        Humidity,
        Co2
    }
}
