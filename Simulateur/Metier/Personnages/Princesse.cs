using Simulateur.Metier.Comportements;
using Simulateur.Metier.Personnages;


namespace Simulateur.Metier
{
    class Princesse:Personnage
    {
        public Princesse(EtatMajor etatmaj, string unNom)
            : base(etatmaj,unNom)
        {
            ComportementSeDeplacer = new ComportementMarcher();
        }

        public override string Afficher()
        {
            return "Princesse " + Nom;
        }
    }
}
