using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionHotel.Model;
using System.Globalization;

namespace GestionHotel.Dal
{
    class TechnicServices
    {
        public static Connect Con = new Connect();
        public static string req;
        public static int ver=0;
        Reservation Reservation =new Reservation();


        public static int ChambresDisponibles()
        {
            int nombreChambresDisponibles = 0;
            try
            {
                Con.openConnect();

                req= "SELECT COUNT(*) FROM chambres WHERE caracteristique = 'Oui'";
                MySqlCommand command = new MySqlCommand(req, Con.GetCon);
                nombreChambresDisponibles = Convert.ToInt32(command.ExecuteScalar());

            
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                Console.WriteLine("Erreur lors du contrôle du nombre de chambres disponibles : " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
            return nombreChambresDisponibles;
        }

        public static int ChambresNoDisponibles()
        {
            int nombreChambresDisponibles = 0;
            try
            {
                Con.openConnect();

                req = "SELECT COUNT(*) FROM chambres WHERE caracteristique = 'Non'";
                MySqlCommand command = new MySqlCommand(req, Con.GetCon);
                nombreChambresDisponibles = Convert.ToInt32(command.ExecuteScalar());


            }
            catch (Exception ex)
            {
                // Gestion des erreurs
              MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
            return nombreChambresDisponibles;
        }

        public static int client()
        {
            int nombreChambresDisponibles = 0;
            try
            {
                Con.openConnect();

                req = "SELECT COUNT(*) FROM client";
                MySqlCommand command = new MySqlCommand(req, Con.GetCon);
                nombreChambresDisponibles = Convert.ToInt32(command.ExecuteScalar());


            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
            return nombreChambresDisponibles;
        }

        public static int reservation()
        {
            int nombreChambresDisponibles = 0;
            try
            {
                Con.openConnect();

                req = "SELECT COUNT(*) FROM reservation";
                MySqlCommand command = new MySqlCommand(req, Con.GetCon);
                nombreChambresDisponibles = Convert.ToInt32(command.ExecuteScalar());


            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
            return nombreChambresDisponibles;
        }

        public int ObtenirNombreReservations()
        {
            int nombreReservations = 0;
           

            try
            {

                Con.openConnect();

                string requeteSQL = "SELECT COUNT(*) FROM reservation";
                MySqlCommand command = new MySqlCommand(requeteSQL, Con.GetCon);

                nombreReservations = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                // Gérer l'exception selon vos besoins
                MessageBox.Show(" " + ex.Message);
            }
            finally
            {
                {
                    Con.closeConnect();
                }
            }

            return nombreReservations;
        }

        public decimal GetPrixTotalReservationsJournee(DateTime date)
        {
            decimal prixTotal = 0;

            try
            {
               
                {
                    Con.openConnect();

                    string sql = "SELECT SUM(prixTotal) FROM reservation WHERE date_save >= @date AND date_save < @datePlusUnJour";
                    MySqlCommand cmd = new MySqlCommand(sql, Con.GetCon);
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    cmd.Parameters.AddWithValue("@datePlusUnJour", date.Date.AddDays(1));

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        prixTotal = Convert.ToDecimal(result);
                    }

                    Con.openConnect();
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions
                Console.WriteLine("Erreur : {0}", ex.Message);
            }

            return prixTotal;
        }


        public int[] GetNombreChambresDisponiblesNonDisponibles()
        {
            int[] nombreChambres = new int[2];

            try
            {
               
                {
                    Con.openConnect();

                    string sql = "SELECT COUNT(*) FROM chambres WHERE caracteristique = 'Oui'";
                    MySqlCommand cmd = new MySqlCommand(sql, Con.GetCon);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        nombreChambres[0] = Convert.ToInt32(result);
                    }

                    sql = "SELECT COUNT(*) FROM chambres WHERE caracteristique = 'Non'";
                    cmd = new MySqlCommand(sql, Con.GetCon);

                    result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        nombreChambres[1] = Convert.ToInt32(result);
                    }
                   

                    Con.closeConnect();
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions
                Console.WriteLine("Erreur : {0}", ex.Message);
            }

            return nombreChambres;
        }

        public static decimal calcul1()
        {
            decimal sommeTotal = 0;
            try
            {
                Con.openConnect();

                string req = "SELECT SUM(prixTotal) FROM reservation";
                MySqlCommand command = new MySqlCommand(req, Con.GetCon);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    sommeTotal = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
            return sommeTotal;
        }


        public static int calcul()
        {
            int nombreTotal = 0;
            try
            {
                Con.openConnect();

                req = "SELECT COUNT(*) FROM user";
                MySqlCommand command = new MySqlCommand(req, Con.GetCon);
                nombreTotal = Convert.ToInt32(command.ExecuteScalar());


            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
            return nombreTotal;
        }
        public static int calculEmp()
        {
            int nombreTotal = 0;
            try
            {
                Con.openConnect();

                req = "SELECT COUNT(*) FROM employer";
                MySqlCommand command = new MySqlCommand(req, Con.GetCon);
                nombreTotal = Convert.ToInt32(command.ExecuteScalar());


            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                Con.closeConnect();
            }
            return nombreTotal;
        }
    }
}


