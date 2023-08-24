using GestionHotel.Controleurs;
using GestionHotel.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionHotel.Views
{
    public partial class Form1chambre : Form
    {
        Connect Con = new Connect();
        public static string req;
        CtrlChambre chambre;
        private static string no, type, caracteristique;
        double prix;

        private void Form1chambre_Load(object sender, EventArgs e)
        {
            try
            {
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur" + ex);
            }
            viewschambre.DataSource = chambre.LoadView();
        }
        public void Clear()
        {
            txtNo.Text = "VG-100-" + this.chambre.RechercherCodeAuto("codechambre");
            txtType.Text = "";
            txtPrix.Text = "";

        }
        private void editerChambre()
        {
            try
            {
                no = txtNo.Text.Trim();
                if (rbnon.Checked == true)
                {
                    caracteristique = "Non";
                }
                else if (rboui.Checked == true)
                {
                    caracteristique = "Oui";
                }
                type= txtType.Text.Trim();
                prix = double.Parse(txtPrix.Text.Trim());

                int ver = this.chambre.Updatechambres(no, type, caracteristique, prix);
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

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Picrecher_Click(object sender, EventArgs e)
        {
            if (txtreche.Text == "")
            {
                MessageBox.Show("Il faut remplir le champ recherhcher");
            }
            else
            {
                string no = txtreche.Text.Trim();
                try
                {
                    bool ck = false;
                    ck = this.chambre.rechercheChambre(no);
                    if (ck)
                    {
                        txtNo.Text = this.chambre.getNo();
                        //rbnon.Text = this.chambre.getCarac();
                        //rboui.Text = this.chambre.getCarac();
                        txtType.Text = this.chambre.getType();
                        txtPrix.Text = this.chambre.getPrix().ToString();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur !!! \n" + ex.Message);
                }
               
            }
        }

        private void viewschambre_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {

                    bool ck = false;
                    DataGridViewRow row = this.viewschambre.Rows[e.RowIndex];
                    string val = row.Cells[0].Value.ToString();
                    txtreche.Text = val;
                    ck = this.chambre.rechercheChambre(val);
                    if (ck)
                    {

                        txtNo.Text = this.chambre.getNo();
                        txtType.Text = this.chambre.getType();
                        txtPrix.Text = this.chambre.getPrix().ToString();
                        if (ck)
                        {
                            if (bool.TryParse(this.chambre.getCarac(), out bool carac))
                            {
                                rbnon.Checked = carac;
                            }
                            else
                            {
                                //rboui.Checked = carac;
                            }
                        }



                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
           // btnAddChambre.Enabled = false;
        }

        public Form1chambre()
        {
            InitializeComponent();
            chambre = new CtrlChambre();
        }

        private void Option_Click(object sender, EventArgs e)
        {
            if (txtreche.Text == "")
            {
                MessageBox.Show("Il faut  recherhcher la chambre d'abord");
            }
            else
            {
                if (txtPrix.Text == "" || rbnon.Text == "")
                {
                    MessageBox.Show("Il faut remplir tous les champs");
                }
                else
                {
                    editerChambre();

                    Clear();
                    viewschambre.DataSource = chambre.LoadView();
                }

            }
        }
    }
}
