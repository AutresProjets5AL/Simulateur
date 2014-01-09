using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur.Metier.Environnements
{
    class Arbre:AccesAbstrait
    {

        protected String Nom;
        protected int Ligne;
        protected int Colonne;

        public Arbre(String nom, int ligne, int colonne)
            : base(nom, ligne, colonne){

                Nom = nom;
                Ligne = ligne;
                Colonne = colonne;

        }


        public override void Interagit(ZoneAbstraite zoneAbstraite)
        {
            Console.WriteLine(GetType().Name + " interagit avec " + zoneAbstraite.GetType().Name);
        }

        public override void afficheDetail()
        {
            Console.WriteLine("Cet arbre est un : " + Nom +
                " , il est positioné à la ligne: " + Ligne + "  et colonne :" + Colonne);
        }
    }
}
