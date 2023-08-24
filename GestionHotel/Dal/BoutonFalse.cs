using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Dal
{
    class BoutonFalse
    {
        public static Connect Con = new Connect();
        public static int ver;
        public static bool IsReceptionistLoggedIn(string nom_utilisateur)
        {
            bool isReceptionistLoggedIn = false;

            try
            {
                // Connexion à la base de données
                //MySqlConnection connection = new MySqlConnection();
                {
                    // Ouverture de la connexion
                    Con.openConnect();

                    // Requête pour récupérer le rôle de l'utilisateur connecté
                    string query = "SELECT role FROM user WHERE nom_utilisateur = @nom_utilisateur";
                    MySqlCommand command = new MySqlCommand(query, Con.GetCon);
                    command.Parameters.AddWithValue("@nom_utilisateur", nom_utilisateur);
                    string role = command.ExecuteReader().ToString();

                    // Vérification si l'utilisateur est un réceptionniste
                    if (role == "'Receptionniste'")
                    {
                        isReceptionistLoggedIn = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la vérification du rôle de l'utilisateur : " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
            return isReceptionistLoggedIn;
        }

    }
}
