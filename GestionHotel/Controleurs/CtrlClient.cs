using GestionHotel.Dal;
using GestionHotel.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Controleurs
{
  class CtrlClient
    {
        public static Connect Con = new Connect();
        public Client Clients = new Client();
       

        public string getNom()
        {
            return Clients.getNom();
        }

        public string getPrenom()
        {
            return Clients.getPrenom();
        }
        public string getSexe()
        {
            return Clients.getSexe();
        }
        public string getDate_naiss()
        {
            return Clients.getDate_naiss();
        }

        public string getAdresse()
        {
            return Clients.getAdresse();
        }
        public string getNationalite()
        {
            return Clients.getNationalite();
        }
        public string getEmail() 
        {
            return Clients.getEmail();

        }
        public string getCin()
        {
            return Clients.getCin();
        }
        public string getTel()
        {
            return Clients.getTel();
        }
        public int AddClient( string nom, string prenom,string sexe,string date_naiss,
            string adresse, string nationalite,string email,string cin,string Tel )
        {
            Client Clients = new Client(nom, prenom,sexe,date_naiss,adresse,nationalite,email,cin,Tel);
            return Dal_client.AddClient(Clients);
        }
        public int UpdateClient(string nom, string prenom, string sexe, string date_naiss,
            string adresse, string nationalite, string email, string cin, string Tel)
        {
            return Dal_client.UpdateClient(nom, prenom, sexe, date_naiss, adresse, nationalite, email, cin,Tel);
        }
        public int SuprimerClient(string cin)
        {
            return Dal_client.SuprimerClient(cin);
        }
        public bool RechercherAvec(string cin)
        {
            Clients = Dal_client.RechercherAvec(cin);
            return (Clients.getCin() != null);
        }

        public static DataTable tb;
        public DataTable LoadViews()
        {
            tb = Dal_client.GetTable();

            return tb;
        }
    }
}
