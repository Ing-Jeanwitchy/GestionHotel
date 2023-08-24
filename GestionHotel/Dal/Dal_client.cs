using GestionHotel.Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client = GestionHotel.Model.Client;
//using GestionHotel.Controleurs;

namespace GestionHotel.Dal
{
  class Dal_client
    {
        public static Connect Con = new Connect();
        public static string req;
        public static int ver;
        //insertion des clients
        public static int AddClient(Client Clientss)
        {

            try
            {

                Con.openConnect();
                req = "INSERT INTO client(nom,prenom,sexe,date_naiss,adresse,nationalite,email,cin,Tel)VALUES(@nom,@prenom,@sexe,@date_naiss,@adresse,@nationalite,@email,@cin,@Tel)";

                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                
                cmd.Parameters.AddWithValue("@nom", Clientss.getNom());
                cmd.Parameters.AddWithValue("@prenom", Clientss.getPrenom());
                cmd.Parameters.AddWithValue("@sexe", Clientss.getSexe());
                cmd.Parameters.AddWithValue("@date_naiss", Clientss.getDate_naiss());
                cmd.Parameters.AddWithValue("@adresse", Clientss.getAdresse());
                cmd.Parameters.AddWithValue("@nationalite", Clientss.getNationalite());
                cmd.Parameters.AddWithValue("@email", Clientss.getEmail());
                cmd.Parameters.AddWithValue("@cin", Clientss.getCin());
                cmd.Parameters.AddWithValue("@Tel", Clientss.getTel());
                ver = cmd.ExecuteNonQuery();
            }
            //Tel, nom, prenom,sexe,date_naiss,adresse,nationalite,email,cin
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
        //modification des clients
        public static int UpdateClient(string nom, string prenom, string sexe, string date_naiss,
            string adresse, string nationalite, string email, string cin, string Tel)
        {
            try
            {

                Con.openConnect();
                req = "update client set  nom='" + nom + "', prenom='" + prenom + "',sexe='" + sexe + "',date_naiss='" + date_naiss + "'," +
                    "adresse='" + adresse + "',nationalite='" + nationalite + "',email='" + email + "',cin='" + 
                    cin + "' , Tel='" + Tel +"'  where cin='"+cin+"'";

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
        //supression des clients
        public static int SuprimerClient(string cin)
        {
            try
            {
                req = "delete from client where cin='" + cin + "'";
                Con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {

            }
            finally
            {
                Con.closeConnect();
            }
            return ver;

        }


        //rechercher des client selon le numero NIF/passpot/cin
        public static Client RechercherAvec(string cin)
        {
            Client client = null;

            try
            {
                Con.openConnect();
                string query = "SELECT * FROM client WHERE cin = @cin ";
                MySqlCommand cmd = new MySqlCommand(query, Con.GetCon);
                cmd.Parameters.AddWithValue("@cin", cin);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    client = new Client();
                    client.setNom(reader["nom"].ToString());
                    client.setPrenom(reader["prenom"].ToString());
                    client.setSexe(reader["sexe"].ToString());
                    client.setdate_naiss(reader["date_naiss"].ToString());
                    client.setadresse(reader["adresse"].ToString());
                    client.setnationalite(reader["nationalite"].ToString());
                    client.setemail(reader["email"].ToString());
                    client.setcin(reader["cin"].ToString());
                    client.setTel(reader["Tel"].ToString());
                }
                else
                {
                    MessageBox.Show("Le client " + cin + " n'existe pas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }

            if (client == null)
            {
                client = new Client(); // Initialisation de l'objet client avec des valeurs par défaut
            }

            return client;
        }



        //pour afficher dans table views
        public static DataTable GetTable()
        {
            DataTable dataTable = null;
            try
            {
                Con.openConnect();

                string query = "SELECT nom, prenom, sexe, date_naiss as 'Date Naissance', adresse, " +
                    "nationalite, email, cin,Tel as 'Telephone' FROM client";
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

