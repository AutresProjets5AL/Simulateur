using Simulateur.Metier.Comportements;

namespace Simulateur.Metier
{
    class Personnage
    {
        public string Nom { get; set; }
        public ComportementSeDeplacer ComportementSeDeplacer { get; set; }

        //-----------------------------------------------------------------------------
        protected Personnage(string sonNom)
        {
             Nom = sonNom;
             ComportementSeDeplacer = null;
           
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


    }
}
