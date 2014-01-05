using System.Collections.Generic;

namespace Simulateur.Metier.Personnages
{
    public abstract class SujetObservé
    {
        private readonly List<Observateur> ObservateurList;


        public void Attach(Observateur observer)
        {
            ObservateurList.Add(observer);
        }

        public void Detach(Observateur observer)
        {
            ObservateurList.Remove(observer);
        }


        public void Notify()
        {
            foreach (Observateur o in ObservateurList)
            {
                o.Update();
            }
        }
    }
}
