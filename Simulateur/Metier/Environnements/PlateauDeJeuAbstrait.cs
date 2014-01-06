using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    abstract class PlateauDeJeuAbstrait
    {
        public abstract AccesAbstrait CreerAcces();
        public abstract ZoneAbstraite CreerZone();

    }
}
