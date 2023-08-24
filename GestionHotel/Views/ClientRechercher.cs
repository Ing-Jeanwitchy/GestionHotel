using GestionHotel.Controleurs;
using GestionHotel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionHotel.Views
{
    public partial class ClientRechercher : Form
    {
        CtrlClient Clients;
        private static string Tel, nom, prenom, sexe,
            date_naiss, adresse, email, nationalite, cin;
            int vae;
        public ClientRechercher()
        {
            InitializeComponent();
            Clients = new CtrlClient();
        }

        private void Clear()
        {
            txtadresse.Text = "";
            txtemail.Text = "";
            txtTelephone.Text = "";
            txtnom.Text = "";
            txtprenom.Text = "";
            txtemail.Text = "";
            txtnationalite.Text = "";
            rbsexeF.Checked = false;
            rbsexeM.Checked = false;
            txtCin.Text = "";
            //rbChoix.Checked = false;
            //GbChoix.Enabled = false;

        }
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddModifier_Click(object sender, EventArgs e)
        {
            if (txtreche.Text == "")
            {
                MessageBox.Show("Il faut  recherhcher le Cleint d'abord");
            }
            else
            {
                if (rbsexeM.Checked == true)
                {
                    sexe = "M";
                }
                else if (rbsexeF.Checked == true)
                {
                    sexe = "F";
                }

                if (txtTelephone.Text == "" || txtnom.Text == "" || txtprenom.Text == "" || sexe == "" ||
                   date_naiss == "" || txtadresse.Text == "" ||
                   txtnationalite.Text == "" || txtemail.Text == "" ||
                   txtCin.Text == "")
                {
                    MessageBox.Show("Il faut remplir tous les champs");
                }
                else
                {
                    EditeterClient();
                    Clear();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            try
            {
                cin = txtreche.Text.Trim();
                vae = this.Clients.SuprimerClient(cin);
                if (vae > 0)
                {
                    //MessageBox.Show("suppresion reussite");
                    Clear();
                }
                else
                {
                    MessageBox.Show("pas de suppresion ");
                    Clear();
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show("Erreur Supression" + ex);

            }
        }
       private void EditeterClient ()
            {
                try
                {
                        nom = txtnom.Text.Trim();
                        prenom = txtprenom.Text.Trim();
                        if (this.Clients.getSexe() == "F")
                        {
                            rbsexeF.Checked = true;
                        }
                        else if (this.Clients.getSexe() == "M")
                        {
                            rbsexeM.Checked = true;
                        }
                        date_naiss = dtnaiss.Value.ToShortDateString().ToString();

                        adresse = txtadresse.Text.Trim();
                        nationalite = txtnationalite.Text.Trim();
                        email = txtemail.Text.Trim();
                        cin = txtCin.Text.Trim();
                        Tel = txtTelephone.Text.Trim();
                        int ver = this.Clients.UpdateClient(nom, prenom, sexe,
                        date_naiss, adresse, email, nationalite,cin,Tel);
                        if (ver > 0)
                        {
                            //MessageBox.Show("Modification reussite");
                        }
                        else
                        {
                            MessageBox.Show("Echec de la Modification ");
                        }
                }


                catch (Exception eg)
                {
                    MessageBox.Show("Erreur lors de la Modification \n" + eg.Message);
                }

            
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
                        txtTelephone.Text = this.Clients.getTel();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur !!! \n" + ex.Message);
                }
                //Clear();
            }

        }
    }
}
