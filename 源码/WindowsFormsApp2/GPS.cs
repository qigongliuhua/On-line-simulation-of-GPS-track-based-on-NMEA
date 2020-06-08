using System;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace MYGPS
{


    public struct ToData 
    {
        public string time;
        public double lng;
        public double lat;
        public int speed;
        public int angle;
    }

    class START
    {
        private static StringBuilder buffer = new StringBuilder();


        public static StringBuilder start(string path)
        {
            StreamReader sr = new StreamReader(path);
            if (sr == null)
            {
            }
            else 
            {
                string str = sr.ReadToEnd();
                Data da = new Data(str);
                Translate(da);

            }

            sr.Close();
            return buffer;
        }

        private static void Translate(Data da)
        {
            List<ToData> pos = new List<ToData>();
            int time = 0;

            foreach (string ch in da.GPRMC)
            {
                ToData toData = new ToData();

                string tem = ch.Substring(6);
                string[] children = tem.Split(new char[] { ',', '*' });
                double lat,lng;

                //lat
                lat = Double.Parse(children[2].Substring(2, 7));
                lat = Int32.Parse(children[2].Substring(0, 2)) + lat / 60;
                toData.lat = lat;

                //lng
                lng = Double.Parse(children[4].Substring(3, 7));
                lng = Int32.Parse(children[4].Substring(0, 3)) + lng / 60;
                toData.lng = lng;

                //time
                time = (time+1) % (60 * 60 * 24);
                toData.time = "2018/3/3" + (time / 3600).ToString() + ":"+((time / 60) % 60).ToString() + ":"+(time % 60).ToString();

                //speed

                //angle


                pos.Add(toData);
            }


            buffer.AppendLine(@"[");
            foreach (ToData tt in pos)
            {
                buffer.AppendLine(@"{""time"":""" + tt.time + @""",""lng"":""" + tt.lng.ToString() + @""",""lat"":""" +
                         tt.lat.ToString() + @""",""speed"":""" + tt.speed.ToString() + @""",""angle"":""" + tt.angle.ToString() + @"""},");

            }
            buffer.Remove(buffer.Length - 3, 3);
            buffer.AppendLine();
            buffer.AppendLine(@"]");

        }
    }
}
