using MySql.Data.MySqlClient;
using System;

namespace GestionHotel.Dal
{
     class Connect
    {
        public static MySqlConnection Con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Lorenzo;database=Hotel");
        public MySqlConnection GetCon
        {
            get
            {
                return Con;
            }
        }
        public void openConnect()
        {
            if (Con.State == System.Data.ConnectionState.Closed)
                Con.Open();
            //Console.WriteLine("Success");
        }

        public void closeConnect()
        {
            if (Con.State == System.Data.ConnectionState.Open)
                Con.Close();
        }
    }
}