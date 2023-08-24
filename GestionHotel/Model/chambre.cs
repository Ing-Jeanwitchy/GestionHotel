using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionHotel.Model
{
    class chambre
    {
        private string no, type, caracteristique;
        private double prix;
        private string role;

        public chambre()
        {

        }
        //constructeur normal


        public chambre(string no, string type, string caracteristique, double prix)

        {
            this.no = no;
            this.type = type;
            this.caracteristique = caracteristique;
            this.prix = prix;
        }

        public chambre(string role)
        {
            this.role = role;
        }

        public void setno(string no)
        {
            this.no = no;
        }
        public void settype(string type)
        {
            this.type = type;
        }
        public void setcaracteristique(string caracteristique)
        {
            this.caracteristique = caracteristique;
        }
        public void setprix(double prix)
        {
            this.prix = prix;
        }
      
        public string getNo()
        {
            return no;
        }

        public string getType()
        {
            return type;
        }


        public string getCarac()
        {
            return caracteristique;
        }
        public double getPrix()
        {
            return prix;
        }
      
       
    }
}
