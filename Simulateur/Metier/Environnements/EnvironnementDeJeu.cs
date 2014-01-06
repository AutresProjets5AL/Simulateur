using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    class EnvironnementDeJeu
    {
        private  ZoneAbstraite zoneAbstraite;
        private  AccesAbstrait accesAbstrait;

        public void CreerPlateauDeJeu(PlateauDeJeuAbstrait Fabrique)
        {
            zoneAbstraite = Fabrique.CreerZone();
            accesAbstrait = Fabrique.CreerAcces();
        }

        public void Run()
        {
            accesAbstrait.Interagit(zoneAbstraite);
        }
    }
}
