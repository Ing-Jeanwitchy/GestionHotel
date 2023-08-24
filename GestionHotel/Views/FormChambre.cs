using GestionHotel.Controleurs;
using GestionHotel.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using GestionHotel.Model;
using System.Management;
using MySqlX.XDevAPI;
using System.Web.Security;
using Google.Protobuf.WellKnownTypes;

namespace GestionHotel.Views
{
    public partial class FormChambre : Form
    {
        Connect Con = new Connect();
        public static string req;
        CtrlChambre chambre;
        private static string no, type, caracteristique;
        double prix;

        private void FormChambre_Load(object sender, EventArgs e)
        {
            try
            {
                bool isReceptionistLoggedIn = BoutonFalse.IsReceptionistLoggedIn(username);
               
                if (isReceptionistLoggedIn)
                {
                    btnAddChambre.Visible = false;
                }
                else
                {
                    btnAddChambre.Visible = true;
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur" + ex);
            }
            viewschambre.DataSource = chambre.LoadView();
            code();
        }
        private  void code()
        {
            string codeRandom = GenererCodeRandom();
            int codeChambre = this.chambre.RechercherCodeAuto("codechambre");
            txtNo.Text = codeRandom + "-" + codeChambre.ToString();
        }
        private string GenererCodeRandom()
        {
            Random random = new Random();
            string code = "VG-" + random.Next(1001, 10000).ToString();

            return code;
        }

        private string  username;

        public FormChambre(string username)
        {
            InitializeComponent();
            this.username = username;
            chambre = new CtrlChambre();
        }
        public void Clear()
        {
            txtNo.Text = "";
            txtType.Text = "";
            rbnon.Checked = false;
            rboui.Checked = false;
            txtPrix.Text = "";

        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        public FormChambre()
        {

            InitializeComponent();
            chambre = new CtrlChambre();
        }

        
        private void editerChambre()
        {
            try
            {
                no = txtNo.Text.Trim();
                if(rbnon.Checked==true)
                {
                    caracteristique = "Non";
                }
                else if (rboui.Checked == true)
                {
                    caracteristique = "Oui";
                }
                type = txtType.Text.Trim();
                prix = double.Parse(txtPrix.Text.Trim());
                
                int ver = this.chambre.Updatechambres(no, type, caracteristique, prix);
                if (ver > 0)
                {
                    //MessageBox.Show("Modification reussite");
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

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Option_Click(object sender, EventArgs e)
        {
            if (txtreche.Text == "")
            {
                MessageBox.Show("Il faut  recherhcher la chambre d'abord");
            }
            else
            {
                if (txtPrix.Text == "" || rbnon.Text == ""  )
                {
                    MessageBox.Show("Il faut remplir tous les champs");
                }
                else
                {
                    editerChambre();
                    btnAddChambre.Enabled = true;
                    Option.Enabled=false;
                    Clear();
                    viewschambre.DataSource = chambre.LoadView();
                    code();
                }

            }
        }

        private void Picrecher_Click_1(object sender, EventArgs e)
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
                        if (this.chambre.getCarac() == "Oui")
                        {
                            rboui.Checked = true;
                        }
                        else if (this.chambre.getCarac() == "Non")
                        {
                            rbnon.Checked = true;
                        }
                        txtType.Text = this.chambre.getType();
                        txtPrix.Text = this.chambre.getPrix().ToString();
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur !!! \n" + ex.Message);
                }
                btnAddChambre.Enabled = false;
                Option.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rboui_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

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
                        if (this.chambre.getCarac() == "Oui")
                        {
                            rboui.Checked = true;
                        }
                        else if (this.chambre.getCarac() == "Non")
                        {
                            rbnon.Checked = true;
                        }


                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
            btnAddChambre.Enabled = false;
            Option.Enabled = true;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Clear();
            btnAddChambre.Enabled = true;
        }

        private void btnAddChambre_Click(object sender, EventArgs e)
        {
            if (txtNo.Text == "" ||   txtPrix.Text == "")
            {
                MessageBox.Show("Il faut remplir tous les champs");
            }

            else if (rbnon.Checked == false && rboui.Checked == false)
            {
                MessageBox.Show("Il faut remplir tous les champs");
            }
        
            else
            {
                AddChambre();
                viewschambre.DataSource = chambre.LoadView();
                code();
                Clear();
            }
        }

        private void AddChambre()
        {
            try
            {
                this.chambre.ModifierCodeAuto("codechambre");
                no = txtNo.Text.Trim();
                prix = double.Parse(txtPrix.Text.Trim());
               
                if (rbnon.Checked == true)
                {
                    caracteristique = "Non";
                }
                else if (rboui.Checked == true)
                {
                    caracteristique = "Oui";
                }
                type=txtType.Text.Trim();
                int ver = this.chambre.AddChambre(no, type, caracteristique, prix);
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
            Clear();
        }

           
        }
      
    }

