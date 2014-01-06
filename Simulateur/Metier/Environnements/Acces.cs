using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    class Acces:AccesAbstrait
    {

        public override void Interagit(ZoneAbstraite zoneAbstraite)
        {
            Console.WriteLine(GetType().Name + " interagit avec " + zoneAbstraite.GetType().Name);
        }
    }
}
