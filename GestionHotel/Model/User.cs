using GestionHotel.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Model
{
    class User
    {
        private string code, nom, prenom, nom_utilisateur, sexe, telephone, role, mot_passe;
            byte []photo;
        
        public User(string code, string nom, string prenom, string nom_utilisateur, string sexe, string telephone, string role, string mot_passe, byte[] photo)

        {
            this.code = code;
            this.nom = nom;
            this.prenom = prenom;
            this.nom_utilisateur = nom_utilisateur;
            this.sexe = sexe;
            this.telephone = telephone;
            this.role = role;
            this.mot_passe=mot_passe;
            this.photo=photo;

        }
        public void setcode(string code)
        {
            this.code = code;
        }
        public  void setnom(string nom) 
        {
            this.nom=nom;
        }
        public void setprenom (string prenom)
        { 
            this.prenom = prenom;
        }
        public void setnom_utilisateur(string nom_utilisateur)
        { 
            this.nom_utilisateur=nom_utilisateur;
        }
        public void setsexe (string sexe)
        { 
            this.sexe = sexe;
        }
        public void settelephone (string telephone)
        { 
            this.telephone=telephone;
        }
        public void setrole(string role)
        {
            this.role = role;
        }
        public void setmot_passe (string mot_passe)
        { 
            this.mot_passe=mot_passe;
        }
        public void setphoto(byte[] photo)
        {
            this.photo = photo;
        }

        public string getcode()
        {
            return this.code;
        }
        public string getnom()
        {
            return nom;
        }
        public string  getprenom()
        { 
            return prenom; 
        }
        public string getnom_utilisateur()
        {
            return nom_utilisateur;
        }
        public string getsexe()
        {
            return sexe;
        }
        public string gettelephone()
        {
            return telephone;
        }
        public string getrole()
        {
            return role;
        }
        public string getmot_passe()
        {
            return mot_passe;
        }
        public byte[] getphoto()
        {
            return photo;
        }
        public User() { }
        
    }
}
