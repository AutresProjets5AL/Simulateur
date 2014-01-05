using Simulateur.Metier.Comportements;
using Simulateur.Metier.Personnages;
using System;
namespace Simulateur.Metier
{
    class Personnage : Observateur
    {
        public string Nom { get; set; }
        private string etatObservé;
        public ComportementSeDeplacer ComportementSeDeplacer { get; set; }
        public EtatMajor EtatMaj { get; set; }

        //-----------------------------------------------------------------------------
        protected Personnage(EtatMajor etatmaj, string sonNom)
        {
             Nom = sonNom;
             ComportementSeDeplacer = null;
             EtatMaj = etatmaj;
           
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
            etatObservé = EtatMaj.ModeFonctionnement().ToString();
            Console.WriteLine("Observer {0} : new state is {1}", Nom, etatObservé);
        }
    }
}
