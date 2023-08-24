using GestionHotel.Controleurs;
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
using System.Web.Security;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionHotel.Views
{
    public partial class PrincipalForm : Form
    {
       // public static Connect Con = new Connect();
        CtrlClient Clients;
        private string _username;
        private string _role;
       private TechnicServices TechnicServices ;
        

        public PrincipalForm()
        {
            
        }
        public PrincipalForm(string username, string role)
        {

            InitializeComponent();
            TechnicServices = new TechnicServices();
            //chambre  = new Controleurs. CtrlChambre();
            Clients = new Controleurs.CtrlClient();
            
            label3.Text = role;
            label2.Text= username;
           
            _username = username;
            _role = role;
            // Vérifier le rôle de l'utilisateur et masquer le bouton "btnUser" en conséquence
            if (role == "Manager" || role == "Receptionniste")
            {
                btnUser.Visible = false;
                btnAdmin.Visible = false;
            }
             if(role == "Receptionniste")
            {
                btnChambre.Visible = false;
                btnchambreRecept.Visible = true;
            }
            else
            {
                btnChambre.Visible = true;
            }
           
        }
    

        private void paneClient_Paint(object sender, PaintEventArgs e)
        {
            Clients = new Controleurs.CtrlClient();
        }

        private void txtrechercher_Click(object sender, EventArgs e)
        {
            

        }
       
            private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChambre());
            accueil();

        }


        private void btnAccueil_Click(object sender, EventArgs e)
        {
          
            paneAcceuil.BringToFront();
            accueil();
        }

        private void AfficherPrixTotalReservationsJournee()
        {
            try
            {
                DateTime date = DateTime.Today; // On utilise la date d'aujourd'hui
                decimal prixTotal = TechnicServices.GetPrixTotalReservationsJournee(date);

                // Afficher le prix total des réservations pour la journée dans un label
                Revnir.Text = prixTotal.ToString("N2") +"HTG";
            }
            catch (Exception ex)
            {
                // Gérer les exceptions
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            openChildForm(new FormClient());
        }
        private void accueil()
        {
            Affichechambredisponible();
            Affichechambrenondisponible();
            AfficherHeureDate();
            clients();
            reservation();
            AfficherPrixTotalReservationsJournee();
            AfficherNombreChambresDisponiblesNonDisponibles();
        }
        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            accueil();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panePrincipale.Controls.Add(childForm);
            panePrincipale.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        
       

        private void panePrincipale_ControlAdded(object sender, ControlEventArgs e)
        {
            //dataServices.DataSource = ser.LoadData();
        }

        private void PictUser_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReservation());
        }

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeForm());
        }

        private void paneForm_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UtilisateurForm()); 
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
        private void AfficherHeureDate()
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        private void Affichechambredisponible()
        {
            int nombreChambresDisponibles =TechnicServices.ChambresDisponibles();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Récupérer l'heure et la date actuelles
            DateTime maintenant = DateTime.Now;

            // Convertir l'heure et la date en chaînes de caractères
            string heure = maintenant.ToString("HH:mm:ss");
            string jour = maintenant.ToString("dddd", new System.Globalization.CultureInfo("fr-FR"));
            string mois = maintenant.ToString("MMMM", new System.Globalization.CultureInfo("fr-FR"));
            string date = maintenant.ToString("dd") + " " + mois + " " + maintenant.ToString("yyyy");

            // Afficher l'heure et la date dans des labels dans la fenêtre
            labelHeure.Text = "heure :" + " " + heure;
            labelDate.Text = jour + " " + date;
        }

        private void btnchambreRecept_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1chambre());
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            // Fermer la fenêtre principale
            this.Close();

            // Ouvrir la fenêtre de connexion
            Login formLogin = new Login();
            formLogin.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminForm());
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void paneAcceuil_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
