using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Model
{
    class Employe
    {
        private string codeemploye, nomemploye, prenomemploye, sexeemploye, 
            datenaiss,telephone, adresseemploye,fonctionemploye,cin;
        private byte[] photoemploye;
        private double Salaireemploye;
        public Employe(string codeemploye, string nomemploye, string prenomemploye, string sexeemploye, string datenaiss,
           string telephone, string adresseemploye, string fonctionemploye, double Salaireemploye, string cin, byte[] photoemploye)
        {
            this.codeemploye = codeemploye;
            this.nomemploye = nomemploye;
            this.prenomemploye = prenomemploye;
            this.sexeemploye = sexeemploye;
            this.datenaiss = datenaiss;
            this.telephone= telephone;
            this.adresseemploye = adresseemploye;
            this.fonctionemploye = fonctionemploye;
            this.Salaireemploye = Salaireemploye;
            this.cin= cin;
            this.photoemploye = photoemploye;
        }
        public Employe()
        {
        }
        public  void setcodeemploye(string codeemploye)
        {
            this.codeemploye = codeemploye;
        }
        public void setnomemploye(string nomemploye)
        {
            this.nomemploye= nomemploye;
        }
        public void setprenomemploye(string prenomemploye)
        {
            this.prenomemploye= prenomemploye;
        }
        public void setsexeemploye(string sexeemploye)
        {
            this.sexeemploye= sexeemploye;
        }
        public void setdatenaiss(string datenaiss)
        { 
            this.datenaiss = datenaiss;
        }
        public void settelephone(string telephone)
        {
            this.telephone = telephone;
        }
        public void setadresseemploye(string adresseemploye)
        {
            this.adresseemploye = adresseemploye;
        }
        public void setfonctionemploye(string fonctionemploye)
        {
            this.fonctionemploye= fonctionemploye;
        }
        public void setSalaireemploye(double salaireemploye)
        {
            this.Salaireemploye= salaireemploye;
        }
        public void setcin(string cin)
        {
            this.cin = cin;
        }
        public void setphotoemploye(byte[] photoemploye)
        {
            this.photoemploye= photoemploye;
        }

        public string getcodeemploye() 
        {
            return codeemploye;
        }
        public string getnomemploye()
        {
            return nomemploye;
        }
        public string getprenomemploye()
        {
            return prenomemploye;
        }
        public string getsexeemploye()
        {
            return sexeemploye;
        }
        public string getdatenaiss()
        {
            return datenaiss;
        }
        public string gettelephone()
        {
            return telephone;
        }
        public string getadresseemploye()
        {
            return adresseemploye;
        }
        public string getfonctionemploye()
        {
            return fonctionemploye;
        }
        public double getSalaireemploye() 
        {
            return Salaireemploye;
        }
        public string getcin()
        {
            return cin;
        }
        public byte[] getphotoemploye()
        {
            return photoemploye;
        }
    }
    
}
