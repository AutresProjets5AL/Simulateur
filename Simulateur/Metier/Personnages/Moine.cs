using Simulateur.Metier.Comportements;
using Simulateur.Metier.Personnages;

namespace Simulateur.Metier
{
    class Moine:Personnage
    {

        
        public Moine(EtatMajor etatmaj, string unNom, int ligne, int colonne)
            : base(etatmaj, unNom, ligne, colonne)
        {
            ComportementSeDeplacer = new ComportementMarcher();
        }

        public override string Afficher()
        {
            return "Moine " + Nom;
        }
    }
}
