using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opticien
{
    class Controleur
    {
        private static ModeleConnexion vmodeleC;
   
        public static ModeleConnexion VmodeleC { get => vmodeleC; set => vmodeleC = value; }

        public static void initConnexion()
        {
            VmodeleC = new ModeleConnexion();
            VmodeleC.seconnecter();
        }
    }
}
