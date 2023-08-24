using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Model
{
    class Client
    {
       // private string Tel, nom, prenom, date_ins;
        private string Tel, nom, prenom, sexe, date_naiss, adresse, nationalite, email, cin;

        //constructeur normal


        public Client(string nom, string prenom, string sex, string date_naiss, string adresse, string nationalite, string email, string cin,string Tel)

        {
           
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sex;
            this.date_naiss = date_naiss;
            this.adresse = adresse;
            this.nationalite = nationalite;
            this.email = email;
            this.cin = cin; 
            this.Tel = Tel;
        }

        public Client()
        {
        }

        //MUTATEUR

        public void setNom(string nom)
        {
            this.nom = nom;
        }
        //public void setnom(string nom)
        //{
        //    this.nom = nom;
        //}
        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }
        public void setSexe(string sexe)
        {
            this.sexe = sexe;
        }
        public void setdate_naiss(string date_naiss)
        {
            this.date_naiss = date_naiss;
        }

        public void setadresse(string adresse)
        {
            this.adresse = adresse;
        }
        public void setnationalite(string nationalite)
        {
            this.nationalite = nationalite;
        }
        public void setemail(string email)
        {
            this.email = email;
        }
        public void setcin(string cin)
        {
            this.cin = cin;
        }
        public void setTel(string Tel)
        {
            this.Tel = Tel;
        }

        //accesseur

        public string getNom()
        {
            return nom;
        }
        public string getPrenom()
        {
            return prenom;
        }
       

        public string getSexe( )
        {
            return sexe;
        }
        public string getDate_naiss()
        {
            return date_naiss;
        }

        public string getAdresse()
        {
            return adresse;
        }
        public string getNationalite()
        {
            return nationalite;
        }
        public string getEmail()
        {
            return email;
        }
        public string getCin()
        {
            return cin;
        }
        public string getTel()
        {
            return Tel;
        }

    }
}
