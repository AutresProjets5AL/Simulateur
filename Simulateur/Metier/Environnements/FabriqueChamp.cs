using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    class FabriqueChamp:FabriquePlateauDeJeuAbstrait
    {
        //boutdeterrain
        public override ZoneAbstraite CreerTerrain(String nom, int ligne, int colonne)
        {
            return new Terrain( nom, ligne, colonne);
        }

        //tunnel
        public override AccesAbstrait CreerArbre(String nom, int ligne, int colonne)
        {
            return new Arbre(nom, ligne, colonne);
        }
    }
}
