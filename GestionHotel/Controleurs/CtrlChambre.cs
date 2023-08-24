using GestionHotel.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionHotel.Model;
using System.Data;
using MySqlX.XDevAPI;
using System.Windows.Forms;

namespace GestionHotel.Controleurs
{
    class CtrlChambre
    {
        public static Connect Con = new Connect();
        public chambre chambre = new chambre();
        public string getNo()
        {
            return chambre.getNo();
        }

        public string getType()
        {
            return chambre.getType();
        }

        public string getCarac()
        {
            return chambre.getCarac();
        }
        public double getPrix()
        {
            return chambre.getPrix();
        }
        public int AddChambre(string no, string type, string caracteristique, double prix)
        {
            chambre chambre = new chambre( no,  type,  caracteristique,  prix);
            return Dal_Chambre.AddChambre(chambre);
        }
        public int Updatechambres(string no,string type, string caracteristique, double prix)
        {
            return Dal_Chambre.Updatechambres(no,type, caracteristique, prix);
        }
        public int SuprimerChambres(string no)
        {
            return Dal_Chambre.SuprimerChambres(no);
        }
        public bool rechercheChambre(string no)
        {
            bool rechercheChambre=false;
            chambre = Dal_Chambre.rechercheChambre(no);
            if (chambre.getNo() != null)
            {
                rechercheChambre = true;
            }
            return rechercheChambre;
        }

        public static DataTable tb;
        public DataTable LoadView()
        {
            tb = Dal_Chambre.GetTable();

            return tb;
        }

        public int RechercherCodeAuto(string table)
        {
            return codeAuto.code_auto(table);
        }
        public void ModifierCodeAuto(string table)
        {
            codeAuto.Modifiercode_auto(table);
        }
    }
}
