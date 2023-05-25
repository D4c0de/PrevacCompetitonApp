using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    static public class StringOperation
    {
        public static int[] StringToValue(string text)
        {
            byte[] value =Encoding.UTF8.GetBytes(text);
            return BytesToInt(value);
        }
        public static int[] BytesToInt(byte[] value)
        {
            int[] ret = new int[(value.Length / 2) + (value.Length % 2)];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = (int)BitConverter.ToUInt16(value, i * 2);
            }

            return ret;
        }
        public static string ValueToString(int[] value)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                sb.Append(Encoding.UTF8.GetString(BitConverter.GetBytes(value[i])));
            }

            return sb.ToString();
        }
    }
}
