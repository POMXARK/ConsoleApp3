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
    public class NewsAgrigatorV2: IObservable<News>
    {
        private readonly List<IObserver<News>> observers;

        public NewsAgrigatorV2()
        {
            observers = new List<IObserver<News>>();
        }

        public IDisposable Subscribe(IObserver<News> observer)
        {
            observers.Add(observer);

            return new Unsubsciber<News>(observers, observer);
        }

        public void Notify(News news)
        {
            foreach (IObserver<News> observer in observers)
            {
                observer.OnNext(news);
            }
        }
    }
}
