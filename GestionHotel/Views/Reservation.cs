using BunifuAnimatorNS;
using GestionHotel.Controleurs;
using GestionHotel.Dal;
using GestionHotel.Model;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Views
{
    public partial class FormReservation : Form

    {
        CtrlReservation Reservation;
        Connect Con = new Connect();
        private static string NomClient, dtdebut, type, chambre, dtfin;
        private int jours;
        private double prixTotal,prix;
        public FormReservation()
        {
            InitializeComponent();
            Reservation = new CtrlReservation();
        }

        private void btnChambre_Click(object sender, EventArgs e)
        {

        }
        public void affacer()
        {
            txtNo.Text = "";
            txtjours.Text = "";
            txtadresse.Text="";
            txtjours.Text = "";
            txtPrix.Text = "";
           // cbNumReser.SelectedItem = null;
            cbResNomClient.SelectedItem = null;
            cbtype.SelectedItem=null;
            txtPrixTotal.Text = "";
            txtnumero.Text = "";


        }

        private void txtjours_Click(object sender, EventArgs e)
        {
            calcul();
        }
      
        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtype.SelectedItem != null)
                try
                {
                    txtPrix.Text = Reservation.PrixCh(cbtype.SelectedItem.ToString()).ToString();
                   txtnumero.Text = Reservation.NumCh(cbtype.SelectedItem.ToString()).ToString();
                }
                catch
                {

                }
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            
            cbResNomClient.Items.AddRange(Reservation.GetListNomClient().ToArray());
            ViewsReserv.DataSource = Reservation.LoadViews();
            affacer();

        }
       // dtFin.ValueChanged += new EventHandler( dtFin.ValueChanged);
        private void dtFin_ValueChanged(object sender, EventArgs e)
        {


            if (cbtype.SelectedItem != null)
                try
                {
                    DateTime dateDebut = dtDebut.Value;
                    DateTime dateFin = dtFin.Value;
                    if (dateDebut == dateFin)
                    {
                        int a = 1;
                        txtjours.Text = a.ToString();
                        dateDebut.Equals(dateFin);
                        txtjours.Text=a.ToString();
                        btnAddReservation.Enabled = true;
                    }
                    else if (dateFin < dateDebut)
                    {
                        btnAddReservation.Enabled = false;
                        MessageBox.Show("Verifier les dates");
                    }
                    else
                    {
                        string numChambre = cbtype.SelectedItem.ToString();
                        Dal_reservation dal = new Dal_reservation();

                        calcul();
                        int tot=int.Parse(txtjours.Text)*int.Parse(txtPrix.Text);
                        txtPrixTotal.Text = tot.ToString();
                        btnAddReservation.Enabled = true;
                        
                    }

                }
                catch
                {
                    //MessageBox.Show("non");
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
                string NomClient = txtreche.Text.Trim();
                try
                {

                    bool ck = false;

                    ck = this.Reservation.rechercheravec(NomClient);
                    if (ck)
                    {

                        cbResNomClient.Text = this.Reservation.GetinfoClient(this.Reservation.getNomClient());
                        cbtype.Text = this.Reservation.GetInfoChambre(this.Reservation.getcbnumero(), "types");
                        txtnumero.Text = this.Reservation.GetInfoChambre(this.Reservation.getcbnumero(),"no");
                        txtPrix.Text= this.Reservation.GetInfoChambre(this.Reservation.getcbnumero(), "prix");
                        string dateDebutStr = this.Reservation.getdtdebut();
                        string dateFinStr = this.Reservation.getdtfin();
                        DateTime dateDebut, dateFin;
                        if (DateTime.TryParse(dateDebutStr, out dateDebut) && DateTime.TryParse(dateFinStr, out dateFin))
                        {
                           
                           
                            dtDebut.Value = dateDebut; 
                            dtFin.Value = dateFin; 
                        }
                        else
                        {
                            // Gérer l'erreur si la conversion échoue
                            MessageBox.Show("Erreur lors de la récupération des dates.");
                        }


                        txtjours.Text = this.Reservation.getjours().ToString();
                        txtPrixTotal.Text = this.Reservation.getprixTotal().ToString();

                        Console.WriteLine(this.Reservation.getdtdebut());
                        Console.WriteLine(this.Reservation.getdtfin());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur !!! \n" + ex.Message);
                }
                btnAddReservation.Enabled = false;
            }
        }

        private void cbNumReser_Click(object sender, EventArgs e)
        {
            if (cbtype.SelectedItem != null)
            {
                // Code à exécuter si la propriété SelectedItem n'est pas null
                var selectedValue = cbtype.SelectedItem.ToString();
                try
                {
                    string chambreType = cbtype.SelectedItem.ToString();
                    string chambreNum = "";
                    string prix = "";

                    Dal_reservation reservationDAL = new Dal_reservation();
                    reservationDAL.GetChambreDetails(chambreType, out chambreNum, out prix);

                   // cbNumReser.Text = chambreNum;
                    txtPrix.Text = prix.ToString() + " HTG";
                }
                

                catch
                {

                }

            }
            else
            {
                // Code à exécuter si la propriété SelectedItem est null
                MessageBox.Show("Aucun élément sélectionné");
            }



        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (txtreche.Text == "")
            {
                MessageBox.Show("Il faut  recherhcher Votre reservation d'abord");
            }
            else
            {
                if (cbResNomClient.Text == "" || cbtype.Text == "" || txtnumero.Text == "" || dtdebut == "" ||
                dtfin == "" || txtjours.Text == "" || txtPrix.Text == "" ||
                txtPrixTotal.Text == "")
                {
                    MessageBox.Show("Il faut remplir tous les champs");
                }
                else
                {
                    editerReservation();
                    ViewsReserv.DataSource = Reservation.LoadViews();
                    affacer();
                }

            }
            
        }
        private void editerReservation()
        {
            try
            {
                NomClient = cbResNomClient.Text.Trim();
                chambre = txtnumero.Text.Trim();
                dtdebut = dtDebut.Text.Trim();
                dtfin = dtFin.Text.Trim();
                jours =int.Parse(txtjours.Text.Trim());
                prixTotal= double.Parse(txtPrixTotal.Text.Trim());
                int ver = this.Reservation.UpdateReservation(NomClient, chambre, dtdebut, dtfin,
                    jours,  prixTotal);
                if (ver > 0)
                {
                    //MessageBox.Show("Modification reussite");
                    int ch = this.Reservation.SetChambreNonDispo(chambre, "Oui");
                    if (ch > 0)
                    {
                        //MessageBox.Show("Cambre modifier");
                    }
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
        private void CalculerPrixTotal()
        {
            
            try
            {
                decimal prixUnitaire = Convert.ToDecimal(txtPrix.Text);
                int quantite = Convert.ToInt32(txtjours.Text);
                decimal prixTotal = prixUnitaire * quantite;
                txtPrixTotal.Text = prixTotal.ToString();

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erreur de format : " + ex.Message);
            }
        }

        private void txtPrixTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbtype_DropDown(object sender, EventArgs e)
        {
            cbtype.Items.Clear();
            cbtype.Items.AddRange(Reservation.GetList().ToArray());
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            if (txtreche.Text == "")
            {
                MessageBox.Show("Il faur rechercher avant l'annulation");
            }
            else
            {
                int ver = this.Reservation.AnnulerReserv(txtreche.Text.Trim());
                int ch = this.Reservation.SetChambreNonDispo(chambre, "Oui");
                ViewsReserv.DataSource = Reservation.LoadViews();
                affacer();
            }
        }

        private void ViewsReserv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                if (e.RowIndex >= 0)
                {

                    bool ck = false;
                    DataGridViewRow row = this.ViewsReserv.Rows[e.RowIndex];
                    string val = row.Cells[0].Value.ToString();
                    txtreche.Text = val;
                    ck = this.Reservation.rechercheravec(val);
                    if (ck)
                    {

                        cbResNomClient.Text = this.Reservation.GetinfoClient(this.Reservation.getNomClient());
                        cbtype.Text = this.Reservation.GetInfoChambre(this.Reservation.getcbnumero(), "types");
                        txtnumero.Text = this.Reservation.GetInfoChambre(this.Reservation.getcbnumero(), "no");
                        txtPrix.Text = this.Reservation.GetInfoChambre(this.Reservation.getcbnumero(), "prix");
                        string dateDebutStr = this.Reservation.getdtdebut();
                        string dateFinStr = this.Reservation.getdtfin();
                        DateTime dateDebut, dateFin;
                        if (DateTime.TryParse(dateDebutStr, out dateDebut) && DateTime.TryParse(dateFinStr, out dateFin))
                        {
                            dtDebut.Value = dateDebut;
                            dtFin.Value = dateFin;
                        }
                        else
                        {
                            // Gérer l'erreur si la conversion échoue
                            MessageBox.Show("Erreur lors de la récupération des dates.");
                        }
                        txtjours.Text = this.Reservation.getjours().ToString();
                        txtPrixTotal.Text = this.Reservation.getprixTotal().ToString();

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
            btnAddReservation.Enabled = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            affacer();
            btnAddReservation.Enabled = true;
        }

        private void cbResNomClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {
            CalculerPrixTotal();
        }

        private void txtjours_TextChanged(object sender, EventArgs e)
        {
            CalculerPrixTotal();
        }
         
        private void calcul()
        {
            // Récupérer les dates des TextBoxes
            DateTime date1, date2;
            if (DateTime.TryParse(dtDebut.Text, out date1) && DateTime.TryParse(dtFin.Text, out date2))
            {
                // Calculer la différence en jours
                TimeSpan difference = date2 - date1;
                int nombreDeJours = (int)difference.TotalDays;

                // Afficher le résultat dans la TextBox "textBoxResult"
                txtjours.Text = nombreDeJours.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez entrer des dates valides.");
            }
        }
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (cbResNomClient.Text == "" || cbtype.Text == "" || dtdebut == "" ||
               dtfin == "" || txtjours.Text == ""  || txtPrix.Text == "" || 
               txtPrixTotal.Text == "")
            {
                MessageBox.Show("Il faut remplir tous les champs");
            }
            else
            {
                AddReservation();
                ViewsReserv.DataSource = Reservation.LoadViews();

                affacer();
            }
        }
        private void AddReservation()
        {

            try
            {
                NomClient = cbResNomClient.Text.Trim();
                chambre = txtnumero.Text.Trim();
                dtdebut = dtDebut.Value.ToShortDateString().ToString();
                dtfin = dtFin.Value.ToShortDateString().ToString();
                jours=int.Parse(txtjours.Text.Trim());
                prixTotal =double.Parse( txtPrixTotal.Text.Trim());
                int ver = this.Reservation.AddReservation(NomClient, chambre, dtdebut, dtfin, jours, prixTotal);
                if (ver > 0)
                {
                    //MessageBox.Show("Insertion reussite");
                    int ch = this.Reservation.SetChambreNonDispo(chambre,"Non");
                    if (ch > 0)
                    {
                       // MessageBox.Show("Cambre modifier");
                    }
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
            ViewsReserv.DataSource = Reservation.LoadViews();
            affacer();
        }


    }
}
