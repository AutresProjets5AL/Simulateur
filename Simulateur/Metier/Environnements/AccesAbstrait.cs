using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    abstract class AccesAbstrait
    {
        public String Nom;
        public int Ligne;
        public int Colonne;

        public AccesAbstrait(String nom, int ligne, int colonne)
        {
            this.Nom = nom;
            this.Ligne = ligne;
            this.Colonne = colonne;
        }

        public abstract void Interagit(ZoneAbstraite zoneAbstraite);

        public abstract void afficheDetail();
    }
}
