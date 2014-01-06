using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simulateur.Metier.Personnages
{
    //Adefinir
   public enum eMode
    {
        NonDefini,
        EnGuerre,
        EnPaix,
        EnRepli
     };
    public class EtatMajor : SujetObservé
    {

       // public eMode modeFonctionnement;
        public eMode modeFonctionnement { get; set; }
        public EtatMajor() : this(null)
        {
        }

        public EtatMajor(EtatMajor unParent)
        {
            Parent = unParent;
        }

        public EtatMajor Parent { get; set; }
        public eMode ModeFonctionnement()
        {
            return modeFonctionnement;
        }
    }
}

