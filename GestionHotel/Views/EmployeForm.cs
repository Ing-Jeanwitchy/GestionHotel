using GestionHotel.Controleurs;
using GestionHotel.Model;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionHotel.Views
{
    public partial class EmployeForm : Form
    {
        CtrlEmploye Employe = new CtrlEmploye();
        CtrlCode code = new CtrlCode();

        private string codeemploye, nomemploye, prenomemploye, sexeemploye,
            datenaiss, telephone, adresseemploye, fonctionemploye, cin;
        double salaireemploye;
        int vae;

        private void txtnifEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtnifEmp.Text.Length >= 11 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Annuler l'événement
            }
        }

        private void txtnifEmp_TextChanged(object sender, EventArgs e)
        {
            if (txtnifEmp.TextLength == 11)
            {
                insereEmployer.Enabled = true;
            }
            if (txtnifEmp.TextLength <= 11)
            {
                insereEmployer.Enabled = true;
            }
            else if (txtnifEmp.TextLength < 11)
            {
                insereEmployer.Enabled = false;
            }
        }
        public void desaktive()
        {
            if (txtTeleEmp.TextLength == 11)
            {
                insereEmployer.Enabled = true;
            }
            if (txtTeleEmp.TextLength > 11)
            {
                insereEmployer.Enabled = false;
            }
            else if (txtTeleEmp.TextLength < 11)
            {
                insereEmployer.Enabled = false;
            }
        }
        private void txtTeleEmp_TextChanged(object sender, EventArgs e)
        {
            desaktive();
        }

        private void txtsalaireEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txtsalaireEmp.TextLength == 11)
            {
                e.Handled = true;
            }
        }
      
        private void code_auto()
        {
            Random random = new Random();
            int randomNumber = random.Next(100, 999);
            txtcodeEmp.Text = "LVG-" + randomNumber.ToString() + "-" +
                this.code.code_auto("codeemp").ToString();
        }
       // #endregion

        private void EmployeForm_Load(object sender, EventArgs e)
        {
            try
            {
               //txtcodeEmp.Text = code_auto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erreur" + ex);
            }
            ViewsEmp.DataSource = Employe.LoadViews();
            string codeRandom = GenererCodeRandom();
            txtcodeEmp.Text = codeRandom;


        }

        private void recherEmp_Click(object sender, EventArgs e)
        {
            if (txtrechercherEmployer.Text == "")
            {
                MessageBox.Show("Il faut remplir le champ recherhcher");
            }
            else
            {
                string num = txtrechercherEmployer.Text.Trim();
                try
                {
                    bool ck = false;
                    ck = this.Employe.rechercheEmployer(num);
                    if (ck)
                    {
                        txtcodeEmp.Text = this.Employe.getcodeemploye();
                        txtnomEmp.Text = this.Employe.getnomemploye();
                        txtPrenomEmp.Text = this.Employe.getprenomemploye();
                        if (this.Employe.getsexeemploye() == "F")
                        {
                            rbsexeFEmp.Checked = true;
                        }
                        else if (this.Employe.getsexeemploye() == "M")
                        {
                            rbsexeMEmp.Checked = true;
                        }
                        string dateNaissStr = this.Employe.getdatenaiss();
                        DateTime dateNaiss;
                        if (DateTime.TryParse(dateNaissStr, out dateNaiss))
                        {
                            dtnaissEmp.Value = dateNaiss; 
                        }
                        else
                        {
                        }
                        txtTeleEmp.Text=this.Employe.gettelephone();
                        txtadresseEmp.Text = this.Employe.getadresseemploye();
                        txtfoncEmp.Text=this.Employe.getfonctionemploye();
                        txtnifEmp.Text = this.Employe.getcin();
                        txtsalaireEmp.Text = this.Employe.getSalaireemploye().ToString();
                        byte[] photoemploye = this.Employe.getphotoemploye();
                        if (photoemploye != null)
                        {
                            using (MemoryStream ms = new MemoryStream(photoemploye))
                            {
                                Image image = Image.FromStream(ms);
                                PicEmp.Image = image; 
                            }
                        }
                        else
                        {
                            PicEmp.Image = null;
                        }
                        //photoemploye = this.Employe.getphotoemploye();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur !!! \n" + ex.Message);
                }
              insereEmployer.Enabled = false;

            }
        }

        private void dtnaissEmp_ValueChanged(object sender, EventArgs e)
        {

        }
        private string GenererCodeRandom()
        {
            Random random = new Random();
            string code = "VG-" + random.Next(1000, 10000).ToString();

            return code;
        }

        private void txtcodeEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txtcodeEmp.Text = "";
            txtnomEmp.Text = "";
            txtPrenomEmp.Text = "";
            datenaiss = "";
            txtTeleEmp.Text = "";
            txtadresseEmp.Text = "";
            txtfoncEmp.Text = "";
            txtnifEmp.Text = "";
            txtsalaireEmp.Text = "";
            rbsexeMEmp.Checked = false;
            rbsexeFEmp.Checked = false;
            txtrechercherEmployer.Text = "";
        }
        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (txtrechercherEmployer.Text == "")
            {
                MessageBox.Show("Il faut  recherhcher la chambre d'abord");
            }
            else
            {
                if (txtcodeEmp.Text == "" || txtnomEmp.Text == "" || txtPrenomEmp.Text == "" ||
                dtnaissEmp.Text == "" || txtTeleEmp.Text == "" ||
                txtadresseEmp.Text == "" || txtfoncEmp.Text == "" ||
                txtnifEmp.Text == "" || txtsalaireEmp.Text == "" || rbsexeMEmp.Checked == false && rbsexeFEmp.Checked == false)
                {
                    MessageBox.Show("Il faut remplir tous les champs");
                }
                else
                {
                    EditeterEmployer(); 
                    insereEmployer.Enabled = true;
                    Clear();
                    ViewsEmp.DataSource = Employe.LoadViews();
                    code_auto();
                }

            }
        }
        private void EditeterEmployer()
        {
            try
            {
                codeemploye=txtcodeEmp.Text.Trim();
                nomemploye = txtnomEmp.Text.Trim();
                prenomemploye = txtPrenomEmp.Text.Trim();
                
                if (rbsexeMEmp.Checked)
                {
                    sexeemploye = "M";
                }
                else if (rbsexeFEmp.Checked)
                {
                    sexeemploye = "F";
                }
                datenaiss = dtnaissEmp.Value.ToShortDateString().ToString();


                telephone = txtTeleEmp.Text.Trim();
                adresseemploye = txtadresseEmp.Text.Trim();
                fonctionemploye = txtfoncEmp.Text.Trim();
                Salaireemploye=double.Parse(txtsalaireEmp.Text.Trim());
                cin = txtnifEmp.Text.Trim();

                int ver = this.Employe.UpdateEmployer(codeemploye, nomemploye, prenomemploye, sexeemploye, datenaiss, telephone, adresseemploye, fonctionemploye,
               cin, Salaireemploye);
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

        private void ViewsEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    bool ck = false;
                    DataGridViewRow row = this.ViewsEmp.Rows[e.RowIndex];
                    string num = row.Cells[0].Value.ToString();
                    txtrechercherEmployer.Text = num;
                    ck = this.Employe.rechercheEmployer(num);
                    if (ck)
                    {

                        txtcodeEmp.Text = this.Employe.getcodeemploye();
                        txtnomEmp.Text = this.Employe.getnomemploye();
                        txtPrenomEmp.Text = this.Employe.getprenomemploye();
                        if (this.Employe.getsexeemploye() == "F")
                        {
                            rbsexeFEmp.Checked = true;
                        }
                        else if (this.Employe.getsexeemploye() == "M")
                        {
                            rbsexeMEmp.Checked = true;
                        }
                        string dateNaissStr = this.Employe.getdatenaiss();
                        DateTime dateNaiss;
                        if (DateTime.TryParse(dateNaissStr, out dateNaiss))
                        {
                            dtnaissEmp.Value = dateNaiss;
                        }
                        else
                        {
                        }
                        txtTeleEmp.Text = this.Employe.gettelephone();
                        txtadresseEmp.Text = this.Employe.getadresseemploye();
                        txtfoncEmp.Text = this.Employe.getfonctionemploye();
                        txtnifEmp.Text = this.Employe.getcin();
                        txtsalaireEmp.Text = this.Employe.getSalaireemploye().ToString();
                        byte[] photoemploye = this.Employe.getphotoemploye();
                        if (photoemploye != null)
                        {
                            using (MemoryStream ms = new MemoryStream(photoemploye))
                            {
                                Image image = Image.FromStream(ms);
                                PicEmp.Image = image;
                            }
                        }
                        else
                        {
                            PicEmp.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
            insereEmployer.Enabled = false;
        }

        private void ViewsEmp_DoubleClick(object sender, EventArgs e)
        {
            Clear();
            insereEmployer.Enabled = true;
        }

        private void btndeleteEmp_Click(object sender, EventArgs e)
        {

            try
            {
                codeemploye = txtcodeEmp.Text.Trim();
                vae = this.Employe.SuprimerEmployer(codeemploye);
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
            ViewsEmp.DataSource = Employe.LoadViews();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Clear();
            insereEmployer.Enabled = true;
        }

        private void txtTeleEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txtTeleEmp.TextLength == 11)
            {
                e.Handled = true;
            }
        }



        byte[] photoemploye;
        private static double Salaireemploye;

        private void insereEmployer_Click(object sender, EventArgs e)
        {
            if (txtcodeEmp.Text == "" || txtnomEmp.Text == "" || txtPrenomEmp.Text == "" ||
                dtnaissEmp.Text == "" || txtTeleEmp.Text == "" ||
                txtadresseEmp.Text == "" || txtfoncEmp.Text == "" ||
                txtnifEmp.Text == "" || txtsalaireEmp.Text=="" || rbsexeMEmp.Checked==false && rbsexeFEmp.Checked==false)
            {
                MessageBox.Show("Il faut remplir tous les champs");
            }
            else
            {
                AddEmployer();
                code_auto();
                Clear();
                ViewsEmp.DataSource = Employe.LoadViews();
            }
        }
        public void AddEmployer()
        {
            DateTime dateNaissance = dtnaissEmp.Value;
            int age = DateTime.Today.Year - dateNaissance.Year;

            if (age < 18)
            {
               // code = txtphone.Text.Trim();
                MessageBox.Show(" Verifier la date de naissance.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    codeemploye = txtcodeEmp.Text.Trim();
                    nomemploye = txtnomEmp.Text.Trim();
                    prenomemploye = txtPrenomEmp.Text.Trim();
                    if (rbsexeMEmp.Checked)
                    {
                        sexeemploye = "M";
                    }
                    else if (rbsexeFEmp.Checked)
                    {
                        sexeemploye = "F";
                    }
                    datenaiss = dtnaissEmp.Value.ToShortDateString().ToString();
                    telephone = txtTeleEmp.Text.Trim();
                    adresseemploye = txtadresseEmp.Text.Trim();
                    fonctionemploye = txtfoncEmp.Text.Trim();
                    cin = txtnifEmp.Text.Trim();
                    Salaireemploye = double.Parse(txtsalaireEmp.Text);
                    int ver = this.Employe.AddEmployer(codeemploye, nomemploye, prenomemploye, sexeemploye,
                datenaiss, telephone, adresseemploye, fonctionemploye, cin, Salaireemploye, imageData);
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
        
        public EmployeForm()
        {
            InitializeComponent();
            Employe = new CtrlEmploye();
        }
        private static byte[] imageData = null;
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
                PicEmp.Image = new Bitmap(dialog.OpenFile());


            }
        }
        
    }

}
