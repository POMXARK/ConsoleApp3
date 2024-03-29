﻿using System;
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
    public class NewsAgrigator: IMyIObservable<News>
    {
        private readonly List<IMyIObserver<News>> observers;

        public NewsAgrigator()
        {
            observers = new List<IMyIObserver<News>>();
        }

        public void Subscribe(IMyIObserver<News> observer)
        {
            observers.Add(observer);
        }

        public void UnSubscribe(IMyIObserver<News> observer)
        {
            observers.Remove(observer);
        }

        public void Notify(News data)
        {
            foreach (IMyIObserver<News> observer in observers)
            {
                observer.Update(data);
            }
        }
    }
}
