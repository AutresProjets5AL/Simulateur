using Simulateur.Metier.Comportements;
using Simulateur.Metier.Personnages;

namespace Simulateur.Metier.Personnages
{
    class Chevalier: Personnage
    {

        public Chevalier(EtatMajor etatmaj,  string unNom)
            : base(etatmaj, unNom)
        {
            ComportementSeDeplacer = new ComportementMarcher();
        }

        public override string Afficher()
        {
            return "Chevalier " + Nom;
        }
    }
}
