using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    ///observer ( наблюдаталь - патерн проектирования который реализует механизм подписок)
    // это когда есть наблюдатель observer и несколько наблюдаемых observable подписанных на него
    // observeble наблюдают за всеми изменениями и каким то образом на них реагируют
    // пример: старт забега по свистку , спортсмены - наблюдатели , свисток - наблюдаемый
    /// </summary>
    public static class PaternsObserver
    {
        public static void CastomPaternObserver()
        {
            /// реализация патерна наблюдатель
            /// работает так же как события,
            /// события плохо подаются тестированию

            /// создание
            var newsAggregator = new NewsAgrigator();
            var stive = new Reader("Stive");
            var bill = new Reader("Bill");

            /// подписка на наблюдаемое
            newsAggregator.Subscribe(stive);
            newsAggregator.Subscribe(bill);

            /// создание новостей 
            var news1 = new News("Title#1", "Content#1");
            var news2 = new News("Title#2", "Content#2");
            var news3 = new News("Title#3", "Content#3");

            /// послать уведомления
            newsAggregator.Notify(news1);
            Thread.Sleep(1000);
            newsAggregator.Notify(news2);
            Thread.Sleep(500);
            newsAggregator.UnSubscribe(bill);
            newsAggregator.Notify(news3);
        }

        public static void PaternObserver()
        {
            /// реализация патерна наблюдатель 
            /// с использованием встроенных интерфейсов
            /// работает так же как события,
            /// события плохо подаются тестированию

            /// создание
            var newsAggregator = new NewsAgrigatorV2();
            var stive = new ReaderV2("Stive");
            var bill = new ReaderV2("Bill");

            /// подписка на наблюдаемое
            var stiveSubscription = newsAggregator.Subscribe(stive);
            var billSubscription = newsAggregator.Subscribe(bill);

            /// создание новостей 
            var news1 = new News("Title#1", "Content#1");
            var news2 = new News("Title#2", "Content#2");
            var news3 = new News("Title#3", "Content#3");

            /// послать уведомления
            newsAggregator.Notify(news1);
            Thread.Sleep(1000);
            newsAggregator.Notify(news2);
            Thread.Sleep(500);
            billSubscription.Dispose();
            newsAggregator.Notify(news3);
        }
    }
}
