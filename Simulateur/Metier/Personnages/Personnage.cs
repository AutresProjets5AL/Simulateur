using Simulateur.Metier.Comportements;
using Simulateur.Metier.Personnages;
using System;
namespace Simulateur.Metier
{
    class Personnage : Observateur
    {
        public string Nom { get; set; }
        private string EtatObservé;
        private int Ligne;
        private int Colonne;
        public ComportementSeDeplacer ComportementSeDeplacer { get; set; }
        public EtatMajor EtatMaj { get; set; }

        //-----------------------------------------------------------------------------
        protected Personnage(EtatMajor etatmaj, string sonNom, int ligne, int colonne)
        {
             Nom = sonNom;
             ComportementSeDeplacer = null;
             EtatMaj = etatmaj;
             Ligne = ligne;
             Colonne = colonne;

           
        }

        //-----------------------------------------------------------------------------
        public virtual string Afficher()
        {
            return Nom;
        }


        //-----------------------------------------------------------------------------
        public int SeDeplacer()
        {
            if (ComportementSeDeplacer != null)
                return ComportementSeDeplacer.SeDeplacer();
            return 3;
        }

        public override void Update()
        {
            EtatObservé = EtatMaj.ModeFonctionnement().ToString();
            Console.WriteLine("Observer {0} : new state is {1}", Nom, EtatObservé);
        }
    }
}
