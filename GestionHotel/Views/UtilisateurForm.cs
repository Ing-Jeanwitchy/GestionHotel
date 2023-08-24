using GestionHotel.Controleurs;
using GestionHotel.Dal;
using GestionHotel.Model;
using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionHotel.Views
{
    public partial class UtilisateurForm : Form
    {
        CtrlUser User
            ;
        Connect Con = new Connect();
        private static string code,nom, prenom, nom_utilisateur, sexe, telephone, role, mot_passe;
        int vae;
        private void UtilisateurForm_Load(object sender, EventArgs e)
        {
            ViewUser.DataSource = User.LoadViews();
            string codeRandom = GenererCodeRandom();
            txtcodeUser.Text = codeRandom;
        }

        private void btnmodiffierUser_Click(object sender, EventArgs e)
        {
            if (txtrechercherUser.Text == "")
            {
                MessageBox.Show("Il faut  recherhcher l'utilisateur d'abord");
            }
            else
            {
                if (rbsexeMuser.Checked == true)
                {
                    sexe = "M";
                }
                else if (rbsexeFuser.Checked == true)
                {
                    sexe = "F";
                }

                if (txtcodeUser.Text == "" || txtusernom.Text == "" || txtuserprenom.Text == "" ||
                cbfonctuser.Text == "" || txtuserprenom.Text == "" ||
                txtmotpass.Text == "" || txtuser.Text == ""
                || rbsexeMuser.Checked == false && rbsexeFuser.Checked == false)
                {
                    MessageBox.Show("Il faut remplir tous les champs");
                }
                else
                {
                    EditeterUser();
                    effacer();
                    insereUser.Enabled = true;
                    btnmodiffierUser.Enabled = false;
                    ViewUser.DataSource = User.LoadViews();
                    
                }
            }
        }
        private void EditeterUser()
        {
            try
            {

                code = txtcodeUser.Text;
                nom = txtusernom.Text.Trim();
                prenom = txtuserprenom.Text.Trim();
                nom_utilisateur = txtuser.Text.Trim();
                if (this.User.getsexe() == "F")
                {
                    rbsexeFuser.Checked = true;
                }
                else if (this.User.getsexe() == "M")
                {
                    rbsexeMuser.Checked = true;
                }
                telephone = txtTeleuser.Text.Trim();
                role = cbfonctuser.Text.Trim();
                mot_passe = txtmotpass.Text.Trim();

                int ver = this.User.UpdateUser(code, nom, prenom, nom_utilisateur, sexe, telephone, role, mot_passe);
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

        private void recherEmp_Click(object sender, EventArgs e)
        {
            if (txtrechercherUser.Text == "")
            {
                MessageBox.Show("Il faut remplir le champ recherhcher");
                insereUser.Enabled = true;
            }
            else
            {
                string num = txtrechercherUser.Text.Trim();
                try
                {
                    bool ck = false;
                    ck = this.User.rechercheUtilisateur(num);
                    if (ck)
                    {
                        txtcodeUser.Text = this.User.getcode();
                        txtusernom.Text = this.User.getnom();
                        txtuserprenom.Text = this.User.getprenom();
                        sexe =  this.User.getsexe();
                        if (sexe=="M")
                        {
                           rbsexeMuser.Checked = true;
                        }
                        else if (sexe == "F")
                        {
                            rbsexeFuser.Checked = true;
                        }
                        txtTeleuser.Text = this.User.gettelephone();
                        txtuser.Text = this.User.getnom_utilisateur();
                        cbfonctuser.Text = this.User.getrole();
                        txtmotpass.Text = this.User.getmot_passe();
                        byte[] photoemploye = this.User.getphoto();
                        if (photoemploye != null)
                        {
                            using (MemoryStream ms = new MemoryStream(photoemploye))
                            {
                                Image image = Image.FromStream(ms);
                                PicUser.Image = image;
                            }
                        }
                        else
                        {
                            PicUser.Image = null;
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur !!! \n" + ex.Message);
                }
                insereUser.Enabled = false;
                btnmodiffierUser.Enabled = true;

            }
        }

        private void ViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    bool ck = false;
                    DataGridViewRow row = this.ViewUser.Rows[e.RowIndex];
                    string Num = row.Cells[0].Value.ToString();
                    txtrechercherUser.Text = Num;
                    ck = this.User.rechercheUtilisateur(Num);
                    if (ck)
                    {

                        txtcodeUser.Text = this.User.getcode();
                        txtusernom.Text = this.User.getnom();
                        txtuserprenom.Text = this.User.getprenom();
                        sexe = this.User.getsexe();
                        if (sexe == "M")
                        {
                            rbsexeMuser.Checked = true;
                        }
                        else if (sexe == "F")
                        {
                            rbsexeFuser.Checked = true;
                        }
                        txtTeleuser.Text = this.User.gettelephone();
                        txtuser.Text = this.User.getnom_utilisateur();
                        cbfonctuser.Text = this.User.getrole();
                        txtmotpass.Text = this.User.getmot_passe();
                        byte[] photoemploye = this.User.getphoto();
                        if (photoemploye != null)
                        {
                            using (MemoryStream ms = new MemoryStream(photoemploye))
                            {
                                Image image = Image.FromStream(ms);
                                PicUser.Image = image;
                            }
                        }
                        else
                        {
                            PicUser.Image = null;
                        }

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
            insereUser.Enabled = false;
            btnmodiffierUser.Enabled = true;

        }

        // byte photo;
        private static byte[] imageData = null;

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            try
            {
                code = txtcodeUser.Text.Trim();
                vae = this.User.SuprimerUser(code);
                if (vae > 0)
                {
                    //MessageBox.Show("suppresion reussite");
                    ViewUser.DataSource = User.LoadViews();
                    effacer();
                }
                else
                {
                    MessageBox.Show("pas de suppresion ");

                }
            }
            catch (Exception ex)
            {


                MessageBox.Show("Erreur Supression" + ex);

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            effacer();
            insereUser.Enabled = true;

        }

        private void btnphotoEmp_Click(object sender, EventArgs e)
        {
            // Ouvrir la boîte de dialogue OpenFileDialog pour sélectionner une image
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fichiers d'images|*.jpg;*.jpeg;*.png;*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Charger les données de l'image sélectionnée dans un tableau de bytes

                using (FileStream stream = new FileStream(dialog.FileName,
                    FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        imageData = reader.ReadBytes((int)stream.Length);
                    }
                }
                PicUser.Image = new Bitmap(dialog.OpenFile());


            }
        }

        public UtilisateurForm()
        {
            InitializeComponent();
            User = new CtrlUser();
        }

        private void txtTeleEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void insereUser_Click(object sender, EventArgs e)
        {
            if (txtcodeUser.Text == "" || txtusernom.Text == "" || txtuserprenom.Text == "" ||
                cbfonctuser.Text == "" || txtuserprenom.Text == "" ||
                txtmotpass.Text == "" || txtuser.Text==""
                || rbsexeMuser.Checked == false && rbsexeFuser.Checked == false)
            {
                MessageBox.Show("Il faut remplir tous les champs");
            }
            else
            {
                AddUser();
                effacer();
                ViewUser.DataSource = User.LoadViews();                                                                             string codeRandom = GenererCodeRandom();
                txtcodeUser.Text = codeRandom;
            }
        }
        public void effacer()
        {
            txtcodeUser.Text="";
            txtusernom.Text="";
            txtuserprenom.Text = "";
            txtuser.Text = "";
            rbsexeMuser.Checked = false;
            rbsexeFuser.Checked= false;
            txtTeleuser.Text = "";
            cbfonctuser.Text = "";
            txtmotpass.Text = "";
            txtrechercherUser.Text = "";
            PicUser.Text= "";
        }
        private void AddUser()
        {

            try
            {
                
                code=txtcodeUser.Text.Trim();
                nom = txtusernom.Text.Trim();
                prenom = txtuserprenom.Text.Trim();
                nom_utilisateur = txtuser.Text.Trim();
                if (rbsexeMuser.Checked)
                {
                    sexe = "M";
                }
                else if (rbsexeFuser.Checked)
                {
                    sexe = "F";
                }
                telephone = txtTeleuser.Text.Trim();
                role = cbfonctuser.Text.Trim();
                
                mot_passe =txtmotpass.Text.Trim();
                int ver = this.User.AddUser(code, nom, prenom, nom_utilisateur, sexe, telephone, role, mot_passe,imageData);
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
            ViewUser.DataSource = User.LoadViews();
            effacer();
        }
        private string GenererCodeRandom()
        {
            Random random = new Random();
            string code = "VG-" + random.Next(1010, 10000).ToString();

            return code;
        }


    }
}
