using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    abstract class ZoneAbstraite
    {
        public String Nom;
        public int Ligne;
        public int Colonne;

        public ZoneAbstraite(String nom, int ligne, int colonne)
        {
            this.Nom = nom;
            this.Ligne = ligne;
            this.Colonne = colonne;
        }

        public abstract void afficheDetail();
    }
}
