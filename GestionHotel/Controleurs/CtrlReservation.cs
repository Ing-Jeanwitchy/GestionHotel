using GestionHotel.Dal;
using GestionHotel.Model;
using GestionHotel.Views;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Controleurs
{
    class CtrlReservation
    {
        public static Connect Con = new Connect();
        public Reservation Reservation = new Reservation();
        private List<string> list;

        public int getNomClient()
        {
            return Reservation.getNomClient();
        }
        public int getcbnumero()
        {
            return Reservation.getchambre();
        }
        public string getdtdebut()
        {
            return Reservation.getdtdebut();
        }
        public string getdtfin()
        {
            return Reservation.getdtfin();
        }
        public int getjours()
        {
            return Reservation.getjours();
        }

        public double getprixTotal()
        {
            return Reservation.getprixTotal();
        }

        public int AddReservation(string NomClient, string cbnumero, string dtdebut,
            string dtfin, int jours, double prixTotal)
        {
            int chambre = Dal_reservation.IdChambre(cbnumero);
            int client = Dal_reservation.IdCLient(NomClient);
            Reservation Reservation = new Reservation(client, chambre, dtdebut, dtfin,
                jours, prixTotal);
            return Dal_reservation.AddReservation(Reservation);
        }
        public int SetChambreNonDispo(string numero, string etat)
        { 
            return Dal_reservation.SetChambreNonDispo(numero,etat);
        }
            public int UpdateReservation(string NomClient, string cbnumero, string dtdebut,
            string dtfin, int jours, double prixTotal)
        {
            int chambre = Dal_reservation.IdChambre(cbnumero);

            int client = Dal_reservation.IdCLient(NomClient);
            return Dal_reservation.UpdateReservation(client, chambre, dtdebut, dtfin,
                jours, prixTotal);
        }
        public int AnnulerReserv(string val)
        {
            return Dal_reservation.AnnulerReservation(val);
        }
        public bool rechercheravec(string cbnumero)
        {
            bool rech = false;
            Reservation = Dal_reservation.rechercheravec(cbnumero);
            if (Reservation.getNomClient().ToString() != null)
            {
                rech = true;
            }
            return rech;
        }
        public List<string> GetList()
        {
            list = Dal_reservation.GetNumerosChambre();
            return list;
        }
        public List<string> GetListNomClient()
        {
            list = Dal_reservation.GetNomsComplets();
            return list;
        }
        public static DataTable tb;
        public DataTable LoadViews()
        {
            tb = Dal_reservation.GetTableReserv();

            return tb;
        }
        public double PrixCh(string val)
        {
            double pr = Dal_reservation.PrixChambres(val);
            return pr;
        }
        public string NumCh(string val)
        {
            string pr = Dal_reservation.NumChambres(val);
            return pr;
        }
        public string GetInfoChambre(int info, string col)
        {
            string val=Dal_reservation.GetInfoChambre(info, col);

            return val;
        }

        public string GetinfoClient(int info )
        {
            string val = Dal_reservation.GetinfoClient(info);

            return val;
        }

    }
}
