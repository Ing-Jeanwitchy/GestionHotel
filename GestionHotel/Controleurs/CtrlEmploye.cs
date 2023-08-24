using GestionHotel.Dal;
using GestionHotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Controleurs
{
    class CtrlEmploye
    {
        public static Connect Con = new Connect();
        public Employe Employe = new Employe();


        public string getcodeemploye()
        {
            return Employe.getcodeemploye();
        }
        public string getnomemploye()
        {
            return Employe.getnomemploye();
        }
        public string getprenomemploye()
        {
            return Employe.getprenomemploye();
        }
        public string getsexeemploye()
        {
            return Employe.getsexeemploye();
        }
        public string getdatenaiss()
        {
            return Employe.getdatenaiss();
        }
        public string gettelephone()
        {
            return Employe.gettelephone();
        }
        public string getadresseemploye()
        {
            return Employe.getadresseemploye();
        }
        public string getfonctionemploye()
        {
            return Employe.getfonctionemploye();
        }
        public double getSalaireemploye()
        {
            return Employe.getSalaireemploye();
        }
        public string getcin()
        {
            return Employe.getcin();
        }
        public byte[] getphotoemploye()
        {
            return Employe.getphotoemploye();
        }

        public int AddEmployer(string codeemploye, string nomemploye, string 
            prenomemploye, string sexeemploye, string datenaiss, string telephone, string adresseemploye,
            string fonctionemploye, string cin, double salaireemploye, byte[] photoemploye)
        {
            Employe Employe = new Employe(codeemploye, nomemploye, prenomemploye, sexeemploye, datenaiss, telephone, adresseemploye, fonctionemploye,
            salaireemploye, cin, photoemploye);
            return Dal_Employe.AddEmployer(Employe);
        }

        public int UpdateEmployer(string codeemploye, string nomemploye, string
            prenomemploye, string sexeemploye, string datenaiss, string telephone, string adresseemploye,
            string fonctionemploye, string cin, double salaireemploye)
        {
            return Dal_Employe.UpdateEmployer(codeemploye, nomemploye, prenomemploye, sexeemploye, datenaiss, telephone, adresseemploye, fonctionemploye,
            cin,salaireemploye);
        }
        public static DataTable tb;
        public DataTable LoadViews()
        {
            tb = Dal_Employe.GetTable();

            return tb;
        }
        public int SuprimerEmployer(string Num)
        {
            return Dal_Employe.SuprimerEmployer(Num);
        }
        public bool rechercheEmployer(string Num)
        {
            bool rechercheChambre = false;
            Employe = Dal_Employe.rechercheEmployer(Num);
            if (Employe.getcodeemploye() != null)
            {
                rechercheChambre = true;
            }
            return rechercheChambre;
        }
    }
}
