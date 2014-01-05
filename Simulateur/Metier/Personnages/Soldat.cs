using Simulateur.Metier.Comportements;
using Simulateur.Metier.Personnages;


namespace Simulateur.Metier
{
    class Soldat:Personnage
    {

        public Soldat(EtatMajor etatmaj, string unNom)
            : base(etatmaj,unNom)
        {
            ComportementSeDeplacer = new ComportementCourrir();
        }

        public override string Afficher()
        {
            return "Soldat " + Nom;
        }

    }
}
