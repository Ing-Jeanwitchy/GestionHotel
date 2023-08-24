using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace GestionHotel.Dal
{
    class Dal_Login
    {
        public static Connect Con = new Connect();
        public static string req;
        public static bool ConnexionValide(string nom_utilisateur, string mot_passe)
        {
            string req = "SELECT COUNT(*) FROM user WHERE BINARY nom_utilisateur = @nom_utilisateur AND BINARY mot_passe = @mot_passe";
            Con.openConnect();

            using (MySqlCommand cmd = new MySqlCommand(req, Con.GetCon))
            {
                cmd.Parameters.AddWithValue("@nom_utilisateur", nom_utilisateur);
                cmd.Parameters.AddWithValue("@mot_passe", mot_passe);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return (count > 0);
            }
        }


        public static string GetRole(string nom_utilisateur, string mot_passe)
        {
          
            {
               
                req = "SELECT role FROM user WHERE nom_utilisateur=@nom_utilisateur AND mot_passe=@mot_passe";
                Con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                cmd.Parameters.AddWithValue("@nom_utilisateur", nom_utilisateur);
                cmd.Parameters.AddWithValue("@mot_passe", mot_passe);
                return cmd.ExecuteScalar().ToString();
            }
        }
    }

    }
    
