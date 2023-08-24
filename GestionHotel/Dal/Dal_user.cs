using GestionHotel.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Dal
{
    class Dal_user
    {
        public static Connect Con = new Connect();
        public static string req;
        public static int ver;
        public static int AddUser(User User)
        {
            try
            {
                Con.openConnect();
                req = "INSERT INTO user(code,nom, prenom, nom_utilisateur, sexe, telephone, role, mot_passe,photo)" +
                    "VALUES(@code,@nom, @prenom, @nom_utilisateur, @sexe, @telephone, @role, @mot_passe,@photo)";

                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                cmd.Parameters.AddWithValue("@code", User.getcode());
                cmd.Parameters.AddWithValue("@nom", User.getnom());
                cmd.Parameters.AddWithValue("@prenom", User.getprenom());
                cmd.Parameters.AddWithValue("@nom_utilisateur", User.getnom_utilisateur());
                cmd.Parameters.AddWithValue("@sexe", User.getsexe());
                cmd.Parameters.AddWithValue("@telephone", User.gettelephone());
                cmd.Parameters.AddWithValue("@role", User.getrole());
                cmd.Parameters.AddWithValue("@mot_passe", User.getmot_passe());
                cmd.Parameters.AddWithValue("@photo", User.getphoto());


                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!!\n" + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }

            return ver;
        }
        public static int UpdateUser(string code,string nom, string prenom, string nom_utilisateur, string sexe, string telephone,
            string role, string mot_passe)
        {
            try
            {

                Con.openConnect();
                req = "update user set  nom ='" + nom + "', prenom='" + prenom + "',nom_utilisateur='" + nom_utilisateur + "',sexe='" + sexe + "'," +
                    "telephone='" + telephone + "',role='" + role + "',mot_passe='" + mot_passe + "'  where code='" + code + "'";

                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!!\n" + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }

            return ver;
        }
        public static User rechercheUtilisateur(string num)
        {
            User User = null;
            User = new User();
            try
            {
                Con.openConnect();
                string query = "SELECT * FROM user WHERE code = @code";
                MySqlCommand cmd = new MySqlCommand(query, Con.GetCon);
                cmd.Parameters.AddWithValue("@code", num);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    User.setcode(reader["code"].ToString());
                    User.setnom(reader["nom"].ToString());
                    User.setprenom(reader["prenom"].ToString());
                    User.setnom_utilisateur(reader["nom_utilisateur"].ToString());
                    User.setsexe(reader["sexe"].ToString());
                    User.settelephone(reader["telephone"].ToString());
                    User.setrole(reader["role"].ToString());
                    User.setmot_passe(reader["mot_passe"].ToString());
                    if (!reader.IsDBNull(reader.GetOrdinal("photo")))
                    {
                        byte[] photoemploye = (byte[])reader["photo"];
                        User.setphoto(photoemploye);
                    }
                }               
            
                else

                {
                    MessageBox.Show("L'utilisateur " + num + " n'exite pas");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
            finally
            {
                Con.closeConnect();
            }
            return User;
        }
        public static int SuprimerUser(string code)
        {
            try
            {
                req = "delete from user where code='" + code + "'";
                Con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                Con.closeConnect();
            }
            return ver;

        }
        public static DataTable GetTable()
        {
            DataTable dataTable = null;
            try
            {
                Con.openConnect();

                string query = "SELECT  code, concat (nom,' ',prenom) as 'Nom complet', nom_utilisateur as 'Nom utilisateur', sexe, telephone as 'Telephone', role as 'Fonction', mot_passe as 'Mot de passe' from user";
                MySqlCommand command = new MySqlCommand(query, Con.GetCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete \n" + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }


            return dataTable;
        }
    }
}
