using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KonyvtarAsztali
{
    internal class Adatbazis
    {
        MySqlCommand command = null;
        MySqlConnection connection = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "konyvtar";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                nyit();
                command = connection.CreateCommand();
                zar();
            } 
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }

 
        }
        private void nyit()
        {
            if (connection.State!=System.Data.ConnectionState.Open) {
            connection.Open();

            }
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();

            }
        }

        public void insertKonyv(int id, string author,int pageCount, int publishYear, string title)
        {
            command.CommandText = "INSERT INTO `books`(`id`, `title`, `author`, `publish_year`, `page_count`, `created_at`, `updated_at`) VALUES (@id,@title,@author,@publish_year,@page_count,@created_at,@updated_at)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@page_count", pageCount);
            command.Parameters.AddWithValue("@publish_year", publishYear);
            command.Parameters.AddWithValue("@title", title);
            nyit();
            command.ExecuteNonQuery();
            zar();

        }



    }
}
