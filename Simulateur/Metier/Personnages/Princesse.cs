using Simulateur.Metier.Comportements;
using Simulateur.Metier.Personnages;


namespace Simulateur.Metier
{
    class Princesse:Personnage
    {
        public Princesse(EtatMajor etatmaj, string unNom, int ligne, int colonne)
            : base(etatmaj, unNom, ligne, colonne)
        {
            ComportementSeDeplacer = new ComportementMarcher();
        }

        public override string Afficher()
        {
            return "Princesse " + Nom;
        }
    }
}
