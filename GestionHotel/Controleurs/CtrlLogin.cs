using GestionHotel.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionHotel.Dal;
using MySql.Data.MySqlClient;

namespace GestionHotel.Controleurs
{
    internal class CtrlLogin
    {
        Connect Cn = new Connect();
        PrincipalForm frm = new PrincipalForm();
        public void CLogin(string username, string pass)
        {
            try
            {
                Cn.openConnect();
                string stm = "select nom_utilisateur,mot_passe from user WHERE nom_utilisateur =@Name AND mot_passe =@Password";
                MySqlCommand cmd = new MySqlCommand(stm, Cn.GetCon);

                cmd.Parameters.AddWithValue("@Name", username);
                cmd.Parameters.AddWithValue("@Password", pass);
                cmd.ExecuteReader();
                PrincipalForm();
            }
            catch (Exception ex)
            {
                Console.WriteLine("login failed \n" + ex.Message);
            }
            Cn.closeConnect();
        }
        private void PrincipalForm()
        {
            frm.Show();
            Login log = new Login();
            log.Hide();

        }

        public CtrlLogin()
        {
        }
    }
}
