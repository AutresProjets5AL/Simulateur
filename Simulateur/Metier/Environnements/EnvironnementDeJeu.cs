using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulateur.Metier.Environnements
{
    class EnvironnementDeJeu
    {
        private List<ZoneAbstraite> ListeZoneAbstraite = new List<ZoneAbstraite>();
        private List<AccesAbstrait> ListeAccesAbstrait = new List<AccesAbstrait>();
        
        public EnvironnementDeJeu(FabriquePlateauDeJeuAbstrait fabrique)
        {
            for (int i = 0; i < 20; i++ ){
                  for (int j = 0; j < 20; j++ ){

                      if ( (j % 5) == 0)
                      {
                        ListeAccesAbstrait.Add(fabrique.CreerArbre("arbre"+i+j,i,j));
                    }else{
                        ListeZoneAbstraite.Add(fabrique.CreerTerrain("terrain"+i+j, i, j));
                    }
                  }
            }
        }

        public void Run()
        {
            /*Test à effacé*/
            Form form = new Form();
            form.AutoSize = true;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            TableLayoutPanel box = new TableLayoutPanel();
            box.AutoSize = true;
            box.RowCount = 20;
            box.ColumnCount = 20;
            /*Fin test*/
           

         
            foreach (AccesAbstrait Acces in ListeAccesAbstrait) // Loop through List with foreach
            {

                /*Test à effacé*/
                TextBox text = new TextBox();
                text.Text = Acces.Nom;
                text.Anchor = AnchorStyles.None;
                box.Controls.Add(text, Acces.Ligne, Acces.Colonne);
                /*Fin test*/
                Acces.afficheDetail();
            }

            foreach (ZoneAbstraite Zone in ListeZoneAbstraite) // Loop through List with foreach
            {

                /*Test à effacé*/
                TextBox text = new TextBox();
                text.Text = Zone.Nom;
                text.Anchor = AnchorStyles.None;
                box.Controls.Add(text, Zone.Ligne, Zone.Colonne);
                /*Fin test*/


                Zone.afficheDetail();
            }

            /* Test à effacé*/
            form.Controls.Add(box);
            form.ShowDialog();
            /*Fin test*/
            
        }

        public List<ZoneAbstraite> getListZoneAbstraite()
        {
            return ListeZoneAbstraite;
        }

        public List<AccesAbstrait> getListAccesAbstrait()
        {
            return ListeAccesAbstrait;
        }

    }
}
