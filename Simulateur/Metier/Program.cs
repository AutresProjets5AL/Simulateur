using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulateur.Metier.Personnages;
using Simulateur.Metier.Comportements;
using Simulateur.Metier;

namespace Simulateur
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            EtatMajor etat = new EtatMajor();
            etat.modeFonctionnement = eMode.EnGuerre;
            etat.Notify();
           // etat.ModeFonctionnement();
          
            Chevalier ch = new Chevalier(etat, "Lancelot", 0, 0);
            Princesse pr = new Princesse(etat, "fiona", 0, 0);
            Soldat sd = new Soldat(etat, "cloud", 0, 0);
            Moine moine = new Moine(etat, "Chaussee", 0, 0);
            etat.Attach(moine);
       
            Console.WriteLine("TOTOT");
        //    Console.WriteLine(ch.SeDeplacer());
          //  Console.WriteLine(sd.SeDeplacer());
            //Console.WriteLine(pr.SeDeplacer());
        
            Console.WriteLine(moine.SeDeplacer());
            Console.WriteLine(moine.EtatMaj.ModeFonctionnement());

            etat.modeFonctionnement = eMode.EnPaix;
            Console.WriteLine(moine.EtatMaj.ModeFonctionnement());

            etat.Notify();
            Console.WriteLine(moine.EtatMaj.ModeFonctionnement());
            Application.Run(new Form1());
 
        }
    }
}
