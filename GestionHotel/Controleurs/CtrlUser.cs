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
    class CtrlUser
    {
        public static Connect Con = new Connect();
        public User User = new User();

        public string getcode()
        {
            return User.getcode();
        }
        public string getnom()
        {
            return User.getnom();
        }
        public string getprenom()
        {
            return User.getprenom(); 
        }
        public string getnom_utilisateur()
        {
            return User.getnom_utilisateur();
        }
        public string getsexe()
        {
            return User.getsexe(); 
        }
        public string gettelephone()
        {
            return User.gettelephone(); 
        }
        public string getrole()
        {
            return User.getrole(); 
        }
        public string getmot_passe()
        {
            return User.getmot_passe();
        }
        public byte[] getphoto()
        {
            return User.getphoto();
        }
        public int AddUser(string code,string nom, string prenom, string nom_utilisateur, string sexe, string telephone,
            string role,string mot_passe, byte[] photo)
        {
            User User = new User(code,nom, prenom, nom_utilisateur, sexe,telephone,role,mot_passe,photo);
            return Dal_user.AddUser(User);
        }

        public int UpdateUser(string code, string nom, string prenom, string nom_utilisateur, string sexe, string telephone,
            string role, string mot_passe)
        {
            return Dal_user.UpdateUser(code, nom, prenom, nom_utilisateur, sexe, telephone, role, mot_passe);
        }
        public bool rechercheUtilisateur(string Num)
        {
            bool rechercheUtilisateur = false;
            User = Dal_user.rechercheUtilisateur(Num);
            if (User.getcode() != null)
            {
                rechercheUtilisateur = true;
            }
            return rechercheUtilisateur;
        }
        public int SuprimerUser(string code)
        {
            return Dal_user.SuprimerUser(code);
        }
        public static DataTable tb;
        public DataTable LoadViews()
        {
            tb = Dal_user.GetTable();

            return tb;
        }
    }
}
