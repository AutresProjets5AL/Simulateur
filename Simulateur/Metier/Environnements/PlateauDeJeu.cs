using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    class PlateauDeJeu : PlateauDeJeuAbstrait
    {
        public override ZoneAbstraite CreerZone()
        {
            return new Zone();
        }

        public override AccesAbstrait CreerAcces()
        {
            return new Acces();
        }
    }
}
