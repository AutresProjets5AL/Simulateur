using Simulateur.Metier.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Comportements
{
    class ComportementRamasse
    {
        public void Ramasse(Objet objet, Personnage personnage)
        {
            objet.AffecteDetenteur(personnage);
        }
    }
}
