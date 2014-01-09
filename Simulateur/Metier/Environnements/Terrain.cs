using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    class Terrain: ZoneAbstraite
    {
        protected String Nom;
        protected int Ligne;
        protected int Colonne;

        public Terrain(String nom, int ligne, int colonne)
            : base(nom, ligne, colonne){
                Nom = nom;
                Ligne = ligne;
                Colonne = colonne;
        
        
        }


        public override void afficheDetail()
        {
            Console.WriteLine("Ce bout de terrain ce nom : " + Nom +
                " , il est positioné à la ligne: " + Ligne + "  et colonne :" + Colonne);
        }
    }
}
