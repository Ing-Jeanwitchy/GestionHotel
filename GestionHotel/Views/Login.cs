using GestionHotel.Controleurs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestionHotel.Dal;
using Org.BouncyCastle.Ocsp;
using MySql.Data.MySqlClient;

namespace GestionHotel.Views
{
    public partial class Login : Form
    {
        Connect Con = new Connect();
        public static string req;
        CtrlLogin log = new CtrlLogin();
        public Login()
        {
            InitializeComponent();
        }
       
        private void btnconnecter_Click(object sender, EventArgs e)
        {

            string nom_utilisateur = txtuser.Text;
            string mot_passe = txtpassword.Text;

            if (Dal_Login.ConnexionValide(nom_utilisateur, mot_passe))
            {
                string role = Dal_Login.GetRole(nom_utilisateur, mot_passe);

                PrincipalForm formMain = new PrincipalForm(nom_utilisateur, role);
                formMain.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

       
    }

    

