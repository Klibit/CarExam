using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtarAsztali
{
    internal static class Program
    {

        public static Form1 baseForm= null;
        public static Adatbazis db = new Adatbazis();
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            baseForm = new Form1();
            Application.Run(baseForm);
        }
    }
}
