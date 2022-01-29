using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class ConcreteSubject : ISubject
    {
        List<IObserver> observers = new List<IObserver> { };

        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update();
            }
        }

        public void RegisterObserver(IObserver item)
        {
            observers.Add(item);
        }

        public void RemoveObserver(IObserver item)
        {
            observers.Remove(item);
        }

        int state;
        public int State
        {
            get { return state; }
            set { state = value; this.NotifyObserver(); }
        }
    }
}