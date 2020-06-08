using System;
using System.Collections.Generic;
using System.Text;

namespace MYGPS
{

    class Data
    {
        public List<string> GPGGA = new List<string>();
        public List<string> GPGSA = new List<string>();
        public List<string> GPGSV = new List<string>();
        public List<string> GPRMC = new List<string>();
        public List<string> GPVTG = new List<string>();
        public List<string> GPGLL = new List<string>();
        public List<string> GPZDA = new List<string>();
        public List<string> another = new List<string>();

        public Data(string data)
        {
            data = data.Remove(0, data.IndexOf('$') + 1);
            data = data.Trim(new char[]{ ' ', '\n','\r' });
            string[] dd = data.Split('$');
            foreach (string ch in dd)
            {
                string da = ch.Trim(new char[] { '\r', '\n' ,' '});
                string sub = ch.Substring(0, 5);
                //public List<string> GPGGA;
                if (sub == "GPGGA") 
                {
                    GPGGA.Add(da);
                    continue;
                }
                //public List<string> GPGSA;
                if (sub == "GPGSA")
                {
                    GPGSA.Add(da);
                    continue;
                }
                //public List<string> GPGSV;
                if (sub == "GPGSV")
                {
                    GPGSV.Add(da);
                    continue;
                }
                //public List<string> GPRMC;
                if (sub == "GPRMC")
                {
                    GPRMC.Add(da);
                    continue;
                }
                //public List<string> GPVTG;
                if (sub == "GPVTG")
                {
                    GPVTG.Add(da);
                    continue;
                }
                //public List<string> GPGLL;
                if (sub == "GPGLL")
                {
                    GPGLL.Add(da);
                    continue;
                }
                //public List<string> GPZDA;
                if (sub == "GPZDA")
                {
                    GPZDA.Add(da);
                    continue;
                }
                //public List<string> another;
                another.Add(da);
            }    
        }


    }
}
