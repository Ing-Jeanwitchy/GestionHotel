using GestionHotel.Dal;
using GestionHotel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GestionHotel.Views
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            TechnicServices = new TechnicServices();

        }
        private TechnicServices TechnicServices;
        private void AdminForm_Load(object sender, EventArgs e)
        {
            int total = TechnicServices.calculEmp();
            lbEmp.Text = total.ToString();
            int user = TechnicServices.calcul();
            lbuser.Text = user.ToString();
            decimal revenir = TechnicServices.calcul1();
            lbtotal.Text = revenir.ToString("N2") + " HTG";
            accueil();

        }
        private void AfficherPrixTotalReservationsJournee()
        {
            try
            {
                DateTime date = DateTime.Today; // On utilise la date d'aujourd'hui
                decimal prixTotal = TechnicServices.GetPrixTotalReservationsJournee(date);

                // Afficher le prix total des réservations pour la journée dans un label
                label1.Text = prixTotal.ToString("HTG");
               
            }
            catch (Exception ex)
            {
                // Gérer les exceptions
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Affichechambredisponible()
        {
            int nombreChambresDisponibles = TechnicServices.ChambresDisponibles();
            Nboui.Text = nombreChambresDisponibles.ToString();
        }
        private void Affichechambrenondisponible()
        {
            int nombreChambresDisponibles = TechnicServices.ChambresNoDisponibles();
            non.Text = nombreChambresDisponibles.ToString();
        }
        private void clients()
        {
            int nombreClient = TechnicServices.client();
            client.Text = nombreClient.ToString();
        }
        private void reservation()
        {
            int nombreChambresDisponibles = TechnicServices.reservation();
            reser.Text = nombreChambresDisponibles.ToString();
        }
        private void accueil()
        {
            Affichechambredisponible();
            Affichechambrenondisponible();
            clients();
            reservation();
            AfficherPrixTotalReservationsJournee();
            AfficherNombreChambresDisponiblesNonDisponibles();
        }
        private void AfficherNombreChambresDisponiblesNonDisponibles()
        {
            try
            {
                int[] nombreChambres = TechnicServices.GetNombreChambresDisponiblesNonDisponibles();
                int nombreClient = TechnicServices.client();
                int nombreReservations = TechnicServices.reservation();

                // Ajouter les données au chart
                chart1.Series.Clear();
                chart1.Series.Add("Chambres disponibles");
                chart1.Series.Add("Chambres non disponibles");
                chart1.Series.Add("Nombre de clients");
                chart1.Series.Add("Nombre de réservations");

                chart1.Series["Chambres disponibles"].Color = Color.Red;
                chart1.Series["Chambres disponibles"].Points.AddXY("", nombreChambres[0]);

                chart1.Series["Chambres non disponibles"].Color = Color.Blue;
                chart1.Series["Chambres non disponibles"].Points.AddXY("", nombreChambres[1]);

                chart1.Series["Nombre de clients"].Points.AddXY("", nombreClient);
                chart1.Series["Nombre de clients"].Color = Color.Yellow;

                chart1.Series["Nombre de réservations"].Points.AddXY("", nombreReservations);
                chart1.Series["Nombre de réservations"].Color = Color.Orange;
                // Ajouter une légende




                // Ajouter un titre pour le chart
                // chart1.Titles.Add("Statistique des donnees");
                Supprimerborder();

            }
            catch (Exception ex)
            {
                // Gérer les exceptions
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Supprimerborder()
        {
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;

            // Cacher les labels des axes X et Y de la chartarea
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = true;

            // Rendre la chartarea sans bordures
            chart1.BorderDashStyle = ChartDashStyle.Solid;
            chart1.BorderColor = Color.Black;
            chart1.BorderWidth = 1;
        }
        private void panePrincipale_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
