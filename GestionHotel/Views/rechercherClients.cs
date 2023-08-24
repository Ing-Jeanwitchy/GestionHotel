using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionHotel.Views
{
    public partial class rechercherChambre : Form
    {
        Controleurs.CtrlClient Clients;
        
  
        private static string code, nom, prenom, sexe,
            date_naiss, adresse, email, nationalite, cin;
            int varCl;

        private void txtsuprimer_Click(object sender, EventArgs e)
        {


            if (txtrech.Text == "")
            {
                MessageBox.Show("Rechercher d'abord le client voulez-vous supprimer");
            }
            else
            {
                string cin = txtrech.Text.Trim();


                try
                {
                    cin = txtrech.Text.Trim();
                    varCl = this.Clients.SuprimerClient(cin);
                    if (varCl > 0)
                    {
                        MessageBox.Show("suppresion reussite");
                        //Clear();
                    }
                    else
                    {
                        MessageBox.Show("pas de suppresion ");
                      //  Clear();
                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show("Erreur Supression" + ex);

                }
            }
            }

            private void btnmodifier_Click_1(object sender, EventArgs e)
            {
            if (rbsexeM.Checked == true)
            {
                sexe = "M";
            }
            else if (rbsexeF.Checked == true)
            {
                sexe = "F";
            }

            if (nom == "" || prenom == "" || sexe == "" ||
                date_naiss == "" || adresse == "" ||
                email == "" || nationalite == "" ||
                cin== "")
            {
                MessageBox.Show("Il faut remplir tous les champs");
            }
            else
            {
                EditeterClient();

                //Clear();
            }
        }

        private void gunaCirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {


            if (txtrech.Text == "")
            {
                MessageBox.Show("Il faut remplir le champ recherhcher");
            }
            else
            {
                string cin = txtrech.Text.Trim();
                try
                {
                    bool ck = false;
                    ck = this.Clients.rechercheravec(cin);
                    if (ck)
                    {
                        //txtcode.Text = this.Clients.getCode();
                        txtnom.Text = this.Clients.getNom();
                        txtPrenom.Text = this.Clients.getPrenom();
                        if (this.Clients.getSexe() == "F")
                        {
                            rbsexeF.Checked = true;
                        }
                        else if (this.Clients.getSexe() == "M")
                        {
                            rbsexeM.Checked = true;
                        }
                        dtnaiss.Text = this.Clients.getDate_naiss();
                        txtadresse.Text = this.Clients.getAdresse();
                        txtnationalite.Text = this.Clients.getNationalite();
                        txtemail.Text = this.Clients.getEmail();
                        txtcin.Text = this.Clients.getCin();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur !!! \n" + ex.Message);
                }
                //Clear();
            
        }
            
        }

        public rechercherChambre()
        {
            InitializeComponent();
            Clients=new Controleurs.CtrlClient();
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditeterClient()
        {
            try
            {
                code = txtcode.Text.Trim();
                nom = txtnom.Text.Trim();
                prenom = txtPrenom.Text.Trim();
                if (rbsexeM.Checked)
                {
                    sexe = "M";
                }
                else if (rbsexeF.Checked)
                {
                    sexe = "F";
                }
                date_naiss = dtnaiss.Value.ToShortDateString().ToString();
                adresse = txtadresse.Text.Trim();
                nationalite = txtnationalite.Text.Trim();
                email = txtemail.Text.Trim();
                cin = txtcin.Text.Trim();
                int ver = this.Clients.UpdateClient(nom, prenom, sexe, date_naiss, adresse,
                  nationalite, email, cin);
                if (ver > 0)
                {
                    MessageBox.Show("Modification reussite");
                }
                else
                {
                    MessageBox.Show("Echec de Modification ");
                }
            }
            catch (Exception eg)
            {
                MessageBox.Show("Erreur lors de la Modification \n" + eg.Message);
            }

        }
        private void btnmodifier_Click(object sender, EventArgs e)
        {

        }
    }
}
