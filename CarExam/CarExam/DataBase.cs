using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CarExam
{
    internal class DataBase
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public DataBase() { 
        
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString);
            sql = conn.CreateCommand();

            try
            {
                kapcsolatNyit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                kapcsolatZar();
            }

        }

        private void kapcsolatZar()
        {
            if (conn.State != System.Data.ConnectionState.Closed) conn.Close();
        }

        private void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
        }

        internal List<Car> getAllCar()
        {
            List<Car> cars = new List<Car>();
            sql.CommandText = "SELECT * FROM `auto` ORDER BY `marka`";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dataReader = sql.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string rendszam = dataReader.GetString("rendszam");
                        string marka = dataReader.GetString("marka");
                        string modell = dataReader.GetString("modell");
                        int gyartasiEv = dataReader.GetInt32("gyartasiEv");
                        DateTime forgalmiErvenyesseg = dataReader.GetDateTime("forgalmiervenyesseg");
                        int vetelAr = dataReader.GetInt32("vetelAr");
                        int kmAllas = dataReader.GetInt32("kmAllas");
                        int hengerUrtartalom = dataReader.GetInt32("hengerűrtartalom");
                        int tomeg = dataReader.GetInt32("tomeg");
                        int teljesitmeny = dataReader.GetInt32("teljesitmeny");
                        cars.Add(new Car(rendszam,marka,modell,gyartasiEv, forgalmiErvenyesseg, vetelAr, kmAllas, hengerUrtartalom, tomeg, teljesitmeny));
                        
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                kapcsolatZar();
            }
            return cars;
        }
    }
}
