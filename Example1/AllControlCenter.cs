using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class AllControlCenter : PersonData, IObserver, IObserverable
    {
        PersonData persondata;
        List<IObserver> observers;

        public AllControlCenter(string Name, double HealthPoint, int Level)
        {
            persondata = new PersonData();
            observers = new List<IObserver>();
            this.Name = Name;
            this.HealthPoint = HealthPoint;
            this.Level = Level;
        }
        
        public void Help()
        {
            if(this.HealthPoint > 0)
               System.Windows.MessageBox.Show(string.Format("我是{0}，正趕來幫忙", this.Name));
            else
                System.Windows.MessageBox.Show(string.Format("我是{0}，已陣亡", this.Name));
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
            this.ObserverName = "";
            this.GetObserverPersonName();
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
            this.ObserverName = "";
            this.GetObserverPersonName();
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
                observer.Help();
        }

        public void BeAttacked(double AttachedHealthPoint)
        {
            this.HealthPoint -= AttachedHealthPoint;
            if (this.HealthPoint <= 0)
            {
                this.HealthPoint = 0;
                foreach (AllControlCenter observer in observers)
                    observer.RemoveObserver(this);
                this.observers = null;
            }
            else
                this.Notify();
            
        }

        public string GetObserverPersonName()
        {
            foreach (AllControlCenter observer in observers)
                this.ObserverName += observer.Name+",";
            return this.ObserverName;
        }

    }
}
