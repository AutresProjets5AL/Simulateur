using Simulateur.Metier.Comportements;

namespace Simulateur.Metier
{
    class Moine:Personnage
    {

        
        public Moine(string unNom)
            : base(unNom)
        {
            ComportementSeDeplacer = new ComportementMarcher();
        }

        public override string Afficher()
        {
            return "Moine " + Nom;
        }
    }
}
