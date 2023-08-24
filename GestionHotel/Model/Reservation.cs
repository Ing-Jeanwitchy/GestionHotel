using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Model
{
    class Reservation
    {
        private string dtdebut, dtfin;
            private double prixTotal;
        private int chambre, jours, NomClient;
        public Reservation(int NomClient,  int chambre, string dtdebut,
            string dtfin, int jours, double prixTotal)

        {
            this.NomClient = NomClient;
            this.chambre = chambre;
            this.dtdebut = dtdebut;
            this.dtfin = dtfin; 
            this.jours = jours; 
            this.prixTotal = prixTotal;
            
        }

        public Reservation()
        {

        }

        public void setNomClient(int NomClient)
        {
            this.NomClient = NomClient;
        }
       
        public void SetChambre(int chambre)
        {
            this.chambre = chambre;
        }
        public void setdtdebut(string dtdebut)
        {
            this.dtdebut = dtdebut;
        }
        
        public void setdtfin(string dtfin)
        {
            this.dtfin=dtfin;
        }
        public void setjours(int jours)
        { 
            this.jours = jours;
        }
        
       
        public void setprixTotal(double prixTotal)
        {
            this.prixTotal = prixTotal;
        }
       
       public int getNomClient()
        {
            return NomClient;
        }
       
        public int getchambre() 
        {
            return chambre;
        }
        public string getdtdebut()
        {
            return dtdebut;
        }
        public string getdtfin()
        {
            return dtfin;
        }
        public int getjours()
        {
            return jours;
        }
      
        public double getprixTotal()
        {
            return prixTotal;
        }


    }
}