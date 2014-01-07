using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Metier.Objets.Comportements;

namespace Simulateur.Metier.Objets
{
    class Objet
    {
        protected string Nom { get; set; }
        protected int Ligne;
        protected int Colonne;
        protected List<ComportementObjets> Comportements;
        protected Personnage Detenteur;

        //-----------------------------------------------------------------------------
        protected Objet(string nom, int ligne, int colonne)
        {
             Nom = nom;
             Ligne = ligne;
             Colonne = colonne;
             Detenteur = null;
             Comportements = new List<ComportementObjets>();
        }

        //-----------------------------------------------------------------------------
        public virtual string Afficher()
        {
            return Nom;
        }
        
        //-----------------------------------------------------------------------------
        public virtual void AjouterComportement(ComportementObjets comportement)
        {
            Comportements.Add(comportement);
        }

        public void AffecteDetenteur(Personnage detenteur)
        {
            Detenteur = detenteur;
        }
    }
}
