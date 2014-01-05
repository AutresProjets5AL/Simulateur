using Simulateur.Metier.Comportements;

namespace Simulateur.Metier
{
    class Princesse:Personnage
    {
        public Princesse(string unNom)
            : base(unNom)
        {
            ComportementSeDeplacer = new ComportementMarcher();
        }

        public override string Afficher()
        {
            return "Princesse " + Nom;
        }
    }
}
