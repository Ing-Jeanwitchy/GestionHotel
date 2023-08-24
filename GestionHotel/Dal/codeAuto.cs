using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Dal
{
    class codeAuto
    {
        public static Connect Con = new Connect();
        public static string req;
        public static int ver;
        public static int code_auto(string table)
        {
            try
            {
                req = "select * from " + table + "";
                Con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    ver = rd.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
            return ver;
        }

        public static void Modifiercode_auto(string table)
        {
            int var = 1 + code_auto(table);
            try
            {
                req = "update " + table + " set id='" + var + "'";
                Con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
        }
    }
}
