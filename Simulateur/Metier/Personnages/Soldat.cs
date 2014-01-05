using Simulateur.Metier.Comportements;

namespace Simulateur.Metier
{
    class Soldat:Personnage
    {

        public Soldat(string unNom)
            : base(unNom)
        {
            ComportementSeDeplacer = new ComportementCourrir();
        }

        public override string Afficher()
        {
            return "Soldat " + Nom;
        }

    }
}
