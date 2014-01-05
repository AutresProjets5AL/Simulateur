using Simulateur.Metier.Comportements;

namespace Simulateur.Metier.Personnages
{
    class Chevalier: Personnage
    {

        public Chevalier(string unNom)
            : base(unNom)
        {
            ComportementSeDeplacer = new ComportementMarcher();
        }

        public override string Afficher()
        {
            return "Chevalier " + Nom;
        }
    }
}
