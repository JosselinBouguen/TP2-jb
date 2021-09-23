using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opticien
{
    class ModeleModele
    {
        public void charger_Modele()
        {
            Controleur.VmodeleC.charger("select descriptif_mod from modele;", Controleur.VmodeleC.DT[1]);
        }
    }
}
