using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    abstract class FabriquePlateauDeJeuAbstrait
    {
        public abstract ZoneAbstraite CreerTerrain(String nom, int ligne, int colonne);
        public abstract AccesAbstrait CreerArbre(String nom, int ligne, int colonne);
    }
}
