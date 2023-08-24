using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionHotel.Dal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using GestionHotel.Controleurs;
using System.Management;

namespace GestionHotel.Views
{
    public partial class FormClient : Form
    {
        CtrlClient Clients;
        Connect Con= new Connect(); 
        private static string code, nom, prenom, sexe,
            date_naiss, adresse, email, nationalite, cin;
        //private bool emailExiste;

        private void panePrincipale_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(txtemail.Text))
            {
                e.Cancel = false;
                txtemail.Select(0, txtemail.Text.Length);
                MessageBox.Show(" Veuillez entrer une adresse email valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txtphone.TextLength == 11)
            {
                e.Handled = true;
            }

        }

        private void txtCin_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txtCin.Text.Length >= 11 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Annuler l'événement
            }
        }
        
        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            desaktive();
        }
        public void desaktive() 
        {
            if (txtphone.TextLength == 11)
            {
                btnAddClient.Enabled = true;
            }
            if (txtphone.TextLength > 11)
            {
                btnAddClient.Enabled = false;
            }
            else if (txtphone.TextLength < 11)
            {
                btnAddClient.Enabled = false;
            }
        }

        private void txtCin_TextChanged(object sender, EventArgs e)
        {
            if (txtCin.TextLength == 11)
            {
                btnAddClient.Enabled = true;
            }
            if (txtCin.TextLength <= 11)
            {
                btnAddClient.Enabled = true;
            }
            else if (txtCin.TextLength < 11)
            {
                btnAddClient.Enabled = false;
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewsClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    bool ck = false;
                    DataGridViewRow row = this.viewsClient.Rows[e.RowIndex];
                    string cin = row.Cells[7].Value.ToString();
                    txtreche.Text = cin;
                    ck = this.Clients.RechercherAvec(cin);
                    if (ck)
                    {

                        txtnom.Text = this.Clients.getNom();
                        txtprenom.Text = this.Clients.getPrenom();
                        if (this.Clients.getSexe() == "F")
                        {
                            rbsexeF.Checked = true;
                        }
                        else if (this.Clients.getSexe() == "M")
                        {
                            rbsexeM.Checked = true;
                        }
                        string dateNaissStr = this.Clients.getDate_naiss();
                        DateTime dateNaiss;
                        if (DateTime.TryParse(dateNaissStr, out dateNaiss))
                        {
                            dtnaiss.Value = dateNaiss; // Assigner la date de naissance au contrôle DateTimePicker
                        }
                        else
                        {
                            // Gérer l'erreur si la conversion échoue
                            MessageBox.Show("Erreur lors de la récupération de la date de naissance.");
                        }
                        txtadresse.Text = this.Clients.getAdresse();
                        txtnationalite.Text = this.Clients.getNationalite();
                        txtemail.Text = this.Clients.getEmail();
                        txtCin.Text = this.Clients.getCin();
                        txtphone.Text = this.Clients.getTel();

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Clean();
            btnAddClient.Enabled = true;
        }

        private void Clean()
        {
            txtadresse.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtnom.Text = "";
            txtprenom.Text = "";
            txtemail.Text = "";
            txtnationalite.Text = "";
            rbsexeF.Checked = false;
            rbsexeM.Checked = false;
            txtCin.Text = "";
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (txtphone.Text == "" || txtnom.Text == "" || txtprenom.Text == "" || sexe == "" ||
               dtnaiss.Text == "" || txtadresse.Text == "" ||
               txtnationalite.Text == "" || txtemail.Text == "" ||
               txtCin.Text == "")
            {
                MessageBox.Show("Il faut remplir tous les champs");
            }
            else
            {
                Addclient();
                viewsClient.DataSource = Clients.LoadViews();
                Clean();
            }
        }

        private void Option_Click(object sender, EventArgs e)
        {
            ClientRechercher rechClient = new ClientRechercher();
            rechClient.Show();
        }


        private void FormClient_Load(object sender, EventArgs e)
        {
            viewsClient.DataSource = Clients.LoadViews();
        }
       
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            viewsClient.DataSource = Clients.LoadViews();
        }

        private void Picrecher_Click(object sender, EventArgs e)
        {


            if (txtreche.Text == "")
            {
                MessageBox.Show("Il faut remplir le champ recherhcher");
            }
            else
            {
                string cin = txtreche.Text.Trim();
                try
                {
                    bool ck = false;
                    ck = this.Clients.RechercherAvec(cin);
                    if (ck)
                    {
                        txtnom.Text = this.Clients.getNom();
                        txtprenom.Text = this.Clients.getPrenom();
                        if (this.Clients.getSexe() == "F")
                        {
                            rbsexeF.Checked = true;
                        }
                        else if (this.Clients.getSexe() == "M")
                        {
                            rbsexeM.Checked = true;
                        }
                        string dateNaissStr = this.Clients.getDate_naiss();
                        DateTime dateNaiss;
                        if (DateTime.TryParse(dateNaissStr, out dateNaiss))
                        {
                            dtnaiss.Value = dateNaiss; // Assigner la date de naissance au contrôle DateTimePicker
                        }
                        else
                        {
                            // Gérer l'erreur si la conversion échoue
                            MessageBox.Show("Erreur lors de la récupération de la date de naissance.");
                        }
                        txtadresse.Text = this.Clients.getAdresse();
                        txtnationalite.Text = this.Clients.getNationalite();
                        txtemail.Text = this.Clients.getEmail();
                        txtCin.Text = this.Clients.getCin();
                        txtphone.Text=this.Clients.getTel();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur !!! \n" + ex.Message);
                }
                btnAddClient.Enabled = false;
              //  Clear();
            }

        }
       
        public FormClient()
        {
            InitializeComponent();
            Clients = new CtrlClient();
        }
        private void Addclient()
        {
            DateTime dateNaissance = dtnaiss.Value;
            int age = DateTime.Today.Year - dateNaissance.Year;

            if (age < 18)
            {
                code = txtphone.Text.Trim();      
                MessageBox.Show(" vous devez être majeur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
            {
                nom = txtnom.Text.Trim();
                prenom = txtprenom.Text.Trim();
                if (rbsexeM.Checked)
                {
                    sexe = "M";
                }
                else if (rbsexeF.Checked)
                {
                    sexe = "F";
                }
                date_naiss = dtnaiss.Value.ToShortDateString().ToString().Trim();
                adresse = txtadresse.Text.Trim();
                nationalite = txtnationalite.Text.Trim();
                email = txtemail.Text.Trim();
                cin=txtCin.Text.Trim();
                code = txtphone.Text.Trim();
                int ver = this.Clients.AddClient( nom, prenom, sexe, date_naiss, adresse,
                nationalite, email, cin,code);
                if (ver > 0)
                {
                    //MessageBox.Show("Insertion reussite");
                }
                else
                {
                    MessageBox.Show("Echec d'insertion ");
                }
            }
            catch (Exception eg)
            {
                MessageBox.Show("Erreur lors de l'insertion \n" + eg.Message);
            }
            }

            

        }
        
    }
}
