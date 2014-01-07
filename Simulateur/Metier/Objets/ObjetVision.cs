using Simulateur.Metier.Objets.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Objets
{
    class ObjetVision : Objet
    {
        public ObjetVision(string nom, int ligne, int colonne, int bonus)
            : base(nom, ligne, colonne)
        {
            AjouterComportement(new ComportementVision(bonus));
        }
    }
}
