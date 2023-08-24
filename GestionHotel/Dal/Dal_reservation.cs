using GestionHotel.Model;
using GestionHotel.Views;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Dal
{
    class Dal_reservation
    {
        public static Connect Con = new Connect();
        public static string req,prix;
        public static int ver;

        public static int AddReservation(Reservation Reservation)
        {

            try
            {

                Con.openConnect();
                req = "INSERT INTO reservation(`NomClient`,`NoChambre`,`date_debut`,`date_fin`,`jours`,`prixTotal`)" +
                    "VALUES(@NomClient,@NoChambre,@date_debut,@date_fin,@jours,@prixTotal)";

                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                cmd.Parameters.AddWithValue("@NomClient", Reservation.getNomClient());
                cmd.Parameters.AddWithValue("@NoChambre", Reservation.getchambre());
                cmd.Parameters.AddWithValue("@date_debut", Reservation.getdtdebut());
                cmd.Parameters.AddWithValue("@date_fin", Reservation.getdtfin());
                cmd.Parameters.AddWithValue("@jours", Reservation.getjours());
                cmd.Parameters.AddWithValue("@prixTotal", Reservation.getprixTotal());
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }

            return ver;
        }

        public static int UpdateReservation(int NomClient,  int cbnumero, string dtdebut,
            string dtfin, int jours,  double prixTotal)
        {
            try
            {
                Con.openConnect();
                req = "update reservation set  NomClient='" + NomClient + "'," +
                    "NoChambre='" + cbnumero + "',date_debut='" + dtdebut + "'," +
                    "date_fin='" + dtfin + "',jours='" + jours + "'" +
                    ",prixTotal= '"+ prixTotal+ "'  where  NoChambre='" + cbnumero + "' or NomClient=" + NomClient + " ";

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
        public static int IdChambre(string no)
        {
            int id = 0;
            string query = "SELECT idchambres FROM chambres WHERE no ='" + no + "'";
          
                Con.openConnect();
                MySqlCommand command = new MySqlCommand(query, Con.GetCon);
              MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id=reader.GetInt32(0);
            }
            reader.Close();
            return id;
            
        }

        public static int SetChambreNonDispo(string no,string etat)
        {
            try
            {
                Con.openConnect();
                req = "update chambres set  caracteristique='"+etat+"' WHERE no ='" + no + "'";
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
        public static int AnnulerReservation(string numero)
        {
            try
            {
                int chambre = Dal_reservation.IdChambre(numero);
                int client = Dal_reservation.IdCLient(numero);
                Con.openConnect();
                req = "delete from reservation where  NoChambre='" + chambre + "' or NomClient=" + client + " ";
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
        public static int IdCLient(string no)
        {
            int id = 0;
            string query = "SELECT idclient FROM client WHERE concat(nom,' ',prenom) ='" + no + "'";

            Con.openConnect();
            MySqlCommand command = new MySqlCommand(query, Con.GetCon);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            return id;

        }
        public static Reservation rechercheravec(string val)
        {
            Reservation reser = null;
            int cl = IdCLient(val);
            int ch = IdChambre(val);
            reser = new Reservation();
            try
            {
                Con.openConnect();
                string query = "SELECT * FROM reservation WHERE NoChambre ="+ch+ " or NomClient=" + cl + "";
                MySqlCommand cmd = new MySqlCommand(query, Con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reser.setNomClient((int.Parse(reader["NomClient"].ToString())));
                    reser.SetChambre(int.Parse(reader["NoChambre"].ToString()));
                    reser.setdtdebut(reader["date_debut"].ToString());
                    reser.setdtfin(reader["date_fin"].ToString());
                    reser.setjours(int.Parse(reader["jours"].ToString()));
                    reser.setprixTotal(double.Parse(reader["prixTotal"].ToString()));
                }
                else
                {
                    MessageBox.Show("Aucune reservation trouve");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
            finally
            {
                Con.closeConnect();
            }
            return reser;
        }

        public static List<string> ListCombo(string type, string chambres)
        {
            List<string> colValues = new List<string>();
            try
            {

                Con.openConnect();
                string query = "SELECT " + type + " FROM " + chambres + " where caracteristique='Oui'";
                MySqlCommand cmd = new MySqlCommand(query, Con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colValues.Add(reader.GetString(type));
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete \n" + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }

            return colValues;
        }

        public static List<string> GetNumerosChambre()
        {
            List<string> numerosChambre = new List<string>();
            using (MySqlConnection connect = new MySqlConnection())
            {
                Con.openConnect();
                string query = "SELECT types FROM chambres WHERE caracteristique= 'Oui'";
                MySqlCommand cmd = new MySqlCommand(query, Con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        numerosChambre.Add(reader["types"].ToString());
                    }
                }

                reader.Close();
            }
            return numerosChambre;
        }

        //pour afficher le nom complet
        public static List<string> GetNomsComplets()
        {
            List<string> nomsComplets = new List<string>();

            Con.openConnect();
            string query = "SELECT CONCAT(nom, ' ', prenom) AS nomComplet FROM client";

            
            {
                using (MySqlCommand cmd = new MySqlCommand(query, Con.GetCon))
                {
                    Con.openConnect();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string nomComplet = reader["nomComplet"].ToString();
                        nomsComplets.Add(nomComplet);
                    }

                    reader.Close();
                }
            }

            return nomsComplets;
        }

        public decimal GetPrixChambre(string type)
        {
            string query = "SELECT prix FROM type WHERE types = @type";
            using (MySqlConnection GetCon = new MySqlConnection())
            {
                Con.openConnect();
                using (MySqlCommand command = new MySqlCommand(query, Con.GetCon))
                {
                    command.Parameters.AddWithValue("@type", type);
                    object result = command.ExecuteScalar();
                    decimal prix;

                    if (result != null && decimal.TryParse(result.ToString(), out prix))
                    {

                        return prix;

                    }


                }
            }
            // Retourne 0 si le prix n'a pas pu être récupéré
            return 0;

        }

        //methode pou selectionner les info d'un chambre
        public static string GetInfoChambre(int info,string col)
        {

            string val = "";
            string query = "SELECT "+col+" FROM chambres WHERE idchambres = '"+info+"'";
                Con.openConnect();
                MySqlCommand command = new MySqlCommand(query, Con.GetCon);
             MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                    val=reader.GetString(col);
                    }
            reader.Close();
            return val;
        }

        public static string GetinfoClient(int info)
        {
            string val = "";
            string query = "SELECT concat (nom,' ',prenom) as nom  FROM client WHERE idclient = '" + info + "'";
            Con.openConnect();
            MySqlCommand command = new MySqlCommand(query, Con.GetCon);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                val = reader.GetString("nom");
            }
            reader.Close();
            return val;
        }

        //methode pour selectionner le no, le prix de la chambres
        public DataTable GetChambresByType(string type)
        {
            string req = "SELECT no, prix FROM chambres WHERE types = @type";
            MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);

            cmd.Parameters.AddWithValue("@type", type);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Con.closeConnect();
            return table;
        }

        public static DataTable GetTableReserv()
        {
            DataTable dataTable = null;
            try
            {
                Con.openConnect();

                string query = "select concat(nom,' ',prenom) as nom,c.types,c.no,date_debut,date_fin,c.prix," +
                    "jours,prixtotal from reservation r,chambres c,client cl where r.NomClient = cl.idclient " +
                    "and r.NoChambre = c.idchambres";
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


        public void GetChambreDetails(string chambreType, out string chambreNum, out string prix)
        {
            chambreNum = "";
            prix = "";

            try
            {
                using (MySqlConnection connection = new MySqlConnection())
                {
                    Con.openConnect();

                    string query = "SELECT no, prix FROM chambres WHERE types = @typeChambre";

                    using (MySqlCommand command = new MySqlCommand(query, Con.GetCon))
                    {
                        command.Parameters.AddWithValue("@typeChambre", chambreType);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                chambreNum = reader.GetString(0);
                                prix = reader.GetString(1);
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération des détails de la chambre : " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
        }

        public static double PrixChambres(string typeChambre)
        {
            double prix = 0;
            string query = "SELECT prix FROM chambres WHERE types = @typeChambre";
            MySqlCommand cmd = new MySqlCommand(query, Con.GetCon);

            cmd.Parameters.AddWithValue("@typeChambre", typeChambre);

            try
            {
                Con.openConnect();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                   prix = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la récupération des numéros de chambre : " + ex.Message);
            }
            finally
            {
                Con.GetCon.Close();
            }
            return prix;
        }

        public static string NumChambres(string typeChambre)
        {
            string num = "";
            string query = "SELECT no FROM chambres WHERE types = @typeChambre";
            MySqlCommand cmd = new MySqlCommand(query, Con.GetCon);

            cmd.Parameters.AddWithValue("@typeChambre", typeChambre);

            try
            {
                Con.openConnect();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    num = reader.GetString(0);
                }
                reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la récupération des numéros de chambre : " + ex.Message);
            }
            finally
            {
                Con.GetCon.Close();
            }
            return num;
        }


        public int CalculerNombreJours(string dateDebutStr, string dateFinStr)
        {
            DateTime dateDebut;
            DateTime dateFin;

            try
            {
                dateDebut = DateTime.Parse(dateDebutStr);
                dateFin = DateTime.Parse(dateFinStr);

                if (dateDebut == dateFin)
                {
                    // Les deux dates sont égales, donc le nombre de jours est 1
                    return 1;
                }
                else if (dateDebut < dateFin)
                {
                    // La première date est inférieure à la deuxième date, donc on retourne le nombre de jours entre les deux dates
                    TimeSpan intervalle = dateFin - dateDebut;
                    return intervalle.Days;
                }
                else
                {
                    // La première date est supérieure à la deuxième date, donc on lance une exception
                    throw new ArgumentException("La date de début doit être inférieure ou égale à la date de fin.");
                }
            }
            catch (Exception ex)
            {
                // Gestion des erreurs potentielles de conversion de chaîne de caractères en dates
                throw new ArgumentException("Les dates fournies ne sont pas valides : " + ex.Message);
            }
        }

    }
}
