using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prop
{
    public struct Connections_prop
    {
        public string adres { get; set; }
        public int port { get; set; }
        public bool preferRTU { get; set; }
        public Connections_prop(string serial) {
            adres = serial;
            port = 0;
            preferRTU = true;
        }
        public Connections_prop(string ip,int port)
        {
            adres = ip;
            this.port = port;
            preferRTU = false;
        }
        public static Connections_prop SetDeafult(Connections_prop prop) 
        {
            if (prop.preferRTU)
            {
                if (string.IsNullOrEmpty(prop.adres))
                {
                    prop.adres = "COM6";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(prop.adres))
                {
                    prop.adres = "192.168.1.101";

                }
                if (prop.port == 0)
                {
                    prop.port = 12345;
                }
                
            }
            return prop;

        }
    }
}
