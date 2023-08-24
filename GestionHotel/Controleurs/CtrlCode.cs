using GestionHotel.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Controleurs
{
    class CtrlCode
    {
        public int code_auto(string table)
        {
            return codeAuto.code_auto(table);
        }
        public void Modifiercode_auto(string table)
        {
            codeAuto.Modifiercode_auto(table);
        }
    }
}
