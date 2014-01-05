using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simulateur.Metier.Personnages
{
    //Adefinir
    enum eMode
    {
        NonDefini,
        EnGuerre,
        EnPaix,
        EnRepli
     };
    public class EtatMajor : SujetObservé
    {

        private eMode modeFonctionnement;

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

