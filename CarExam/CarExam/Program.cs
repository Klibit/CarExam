using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarExam
{
    internal static class Program
    {
        public static List<Car> cars = new List<Car>();
        public static DataBase dataBase = null;
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dataBase = new DataBase();
            cars = dataBase.getAllCar();
            Application.Run(new FormOpen());
        }
    }
}
