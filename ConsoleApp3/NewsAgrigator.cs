using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Агрегатор - агрегирует новости (собирает в одну кучу)
    /// Хранит список читателей, которые подписались на него
    /// </summary>
    public class NewsAgrigator: IObservable<News>
    {
        private readonly List<IObserver<News>> observers;

        public NewsAgrigator()
        {
            observers = new List<IObserver<News>>();
        }

        public void Subscibe(IObserver<News> observer)
        {
            observers.Add(observer);
        }

        public void UnSubscibe(IObserver<News> observer)
        {
            observers.Remove(observer);
        }

        public void Notify(News data)
        {
            foreach (IObserver<News> observer in observers)
            {
                observer.Update(data);
            }
        }
    }
}
