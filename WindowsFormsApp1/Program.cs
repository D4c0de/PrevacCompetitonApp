//Verison 1.0.2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public static UInt16[] token;
        public static int tier;
        /// <summary>
        /// Główny punkt wejś0cia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
            Application.Run(new Form1());
        }
    }
}
