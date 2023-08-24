using GestionHotel.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionHotel.Dal
{
    class Dal_Chambre
    {
        public static Connect Con = new Connect();
        public static string req;
        public static int ver ;
        
        //pour les insertion des chmabres
        public static int AddChambre(chambre chambre)
        {
            try
            {
                Con.openConnect();
                req = "INSERT INTO chambres(no,  types,  caracteristique,  prix)VALUES(@no,@type,@caracteristique,@prix)";

                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                cmd.Parameters.AddWithValue("@no", chambre.getNo());
                cmd.Parameters.AddWithValue("@type", chambre.getType());
                cmd.Parameters.AddWithValue("@caracteristique", chambre.getCarac());
                cmd.Parameters.AddWithValue("@prix", chambre.getPrix());
               
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
        //pour modification des chmabres
        public static int Updatechambres(string no,string type, string caracteristique, double prix)
        {
            try
            {

                Con.openConnect();
                req = "update chambres set  types='" + type + "', caracteristique='" + caracteristique + 
                    "',prix='" + prix + "' where no = '" + no + "'";

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
        //pour la supression de chambre
        public static int SuprimerChambres(string no)
        {
            try
            {
                req = "delete from chambres where no='" + no + "'";
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
        //rechercher chambre
        public static chambre rechercheChambre(string no)
        {
            chambre chambre = null;
            chambre = new chambre();
            try
            {
                Con.openConnect();
                string query = "SELECT * FROM chambres WHERE no = @no";
                MySqlCommand cmd = new MySqlCommand(query, Con.GetCon);
                cmd.Parameters.AddWithValue("@no", no);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    chambre.setno(reader["no"].ToString());
                    chambre.settype(reader["types"].ToString());
                    chambre.setcaracteristique(reader["caracteristique"].ToString());
                    chambre.setprix(double.Parse(reader["prix"].ToString()));
                    
                   
                }
                else
                    
                {
                    MessageBox.Show("La chambre " + no + " n'exite pas");
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
            return chambre;
        }
        

        public static DataTable GetTable()
        {
            DataTable dataTable = null;
            try
            {
                Con.openConnect();

                string query = "SELECT no as 'Numero chambre',  types,  caracteristique as'Etat',  prix FROM chambres";
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

        

        public static int RecherCodeEmp()
        {
            try
            {
                req = "select * from codechambre";
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

        public static void CodeEmp()
        {
            int var = 1 + RecherCodeEmp();
            try
            {
                req = "update codechambre set idcodeChambre='" + var + "'";
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
