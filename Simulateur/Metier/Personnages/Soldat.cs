using Simulateur.Metier.Comportements;
using Simulateur.Metier.Personnages;


namespace Simulateur.Metier
{
    class Soldat:Personnage
    {

        public Soldat(EtatMajor etatmaj, string unNom, int ligne, int colonne)
            : base(etatmaj, unNom, ligne, colonne)
        {
            ComportementSeDeplacer = new ComportementCourrir();
        }

        public override string Afficher()
        {
            return "Soldat " + Nom;
        }

    }
}
