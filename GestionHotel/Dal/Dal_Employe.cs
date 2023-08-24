using GestionHotel.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Dal
{
    class Dal_Employe
    {
        public static Connect Con = new Connect();
        public static string req;
        public static int ver;
        public static int AddEmployer(Employe Employe)
        {
            try
            {
                Con.openConnect();
                req = "INSERT INTO employer(codeemploye,nomemploye,prenomemploye,sexeemploye,datenaiss,telephone,adresseemploye," +
                    "fonctionemploye,Salaireemploye,cin,photoemploye)" +
                    "VALUES(@codeemploye,@nomemploye,@prenomemploye,@sexeemploye,@datenaiss,@telephone," +
                    "@adresseemploye,@fonctionemploye,@Salaireemploye,@cin,@photoemploye)";

                MySqlCommand cmd = new MySqlCommand(req, Con.GetCon);
                cmd.Parameters.AddWithValue("@codeemploye", Employe.getcodeemploye());
                cmd.Parameters.AddWithValue("@nomemploye", Employe.getnomemploye());
                cmd.Parameters.AddWithValue("@prenomemploye", Employe.getprenomemploye());
                cmd.Parameters.AddWithValue("@sexeemploye", Employe.getsexeemploye());
                cmd.Parameters.AddWithValue("@datenaiss", Employe.getdatenaiss());
                cmd.Parameters.AddWithValue("@telephone", Employe.gettelephone());
                cmd.Parameters.AddWithValue("@adresseemploye", Employe.getadresseemploye());
                cmd.Parameters.AddWithValue("@fonctionemploye", Employe.getfonctionemploye());
                cmd.Parameters.AddWithValue("@Salaireemploye", Employe.getSalaireemploye());
                cmd.Parameters.AddWithValue("@cin", Employe.getcin());
                cmd.Parameters.AddWithValue("@photoemploye", Employe.getphotoemploye());

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
        public static Employe rechercheEmployer(string num)
        {
            Employe employe = null;
            try
            {
                Con.openConnect();
                string query = "SELECT * FROM employer WHERE codeemploye = @no";
                MySqlCommand cmd = new MySqlCommand(query, Con.GetCon);
                cmd.Parameters.AddWithValue("@no", num);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    employe = new Employe();
                    employe.setcodeemploye(reader["codeemploye"].ToString());
                    employe.setnomemploye(reader["nomemploye"].ToString());
                    employe.setprenomemploye(reader["prenomemploye"].ToString());
                    employe.setsexeemploye(reader["sexeemploye"].ToString());
                    employe.setdatenaiss(reader["datenaiss"].ToString());
                    employe.settelephone(reader["telephone"].ToString());
                    employe.setadresseemploye(reader["adresseemploye"].ToString());
                    employe.setfonctionemploye(reader["fonctionemploye"].ToString());
                    employe.setcin(reader["cin"].ToString());
                    employe.setSalaireemploye(double.Parse(reader["Salaireemploye"].ToString()));

                    if (!reader.IsDBNull(reader.GetOrdinal("photoemploye")))
                    {
                        byte[] photoemploye = (byte[])reader["photoemploye"];
                        employe.setphotoemploye(photoemploye);
                    }
                }
                else
                {
                    MessageBox.Show("L'employé " + num + " n'existe pas");
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
            return employe;
        }


        //Code
        public static int RecherCodeEmp()
        {
            try
            {
                req = "select * from codeemp";
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
                req = "update codeemp set idcodeEmp='" + var + "'";
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

        public static DataTable GetTable()
        {
            DataTable dataTable = null;
            try
            {
                Con.openConnect();

                string query = "SELECT codeemploye as 'Code', concat (nomemploye,' ',prenomemploye) as 'Nom complet',  sexeemploye as'Sexe', datenaiss as'Naissance'," +
                    "telephone as 'Telephone',  adresseemploye as 'Adresse' ,fonctionemploye as 'Fonction', Salaireemploye as'Salaire', cin FROM employer";
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
        public static int UpdateEmployer(string codeemploye, string nomemploye, string
            prenomemploye, string sexeemploye, string datenaiss, string telephone, string adresseemploye,
            string fonctionemploye, string cin, double salaireemploye)
        {
            try
            {

                Con.openConnect();
                req = "update employer set  nomemploye='" + nomemploye + "', prenomemploye='" + prenomemploye + "',sexeemploye='" + sexeemploye + "',datenaiss='" + datenaiss + "'," +
                    "telephone='" + telephone + "',adresseemploye='" + adresseemploye + "',fonctionemploye='" + fonctionemploye + "',cin='" +
                    cin + "' , salaireemploye='" + salaireemploye + "'  where cin='" + cin + "' or codeemploye='"+codeemploye+ "'";

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

        public static int SuprimerEmployer(string num)
        {
            try
            {
                req = "delete from employer where codeemploye='" + num + "'";
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
    }
}
