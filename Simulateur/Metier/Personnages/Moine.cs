using Simulateur.Metier.Comportements;
using Simulateur.Metier.Personnages;

namespace Simulateur.Metier
{
    class Moine:Personnage
    {

        
        public Moine(EtatMajor etatmaj, string unNom)
            : base(etatmaj,unNom)
        {
            ComportementSeDeplacer = new ComportementMarcher();
        }

        public override string Afficher()
        {
            return "Moine " + Nom;
        }
    }
}
