using ConsoleApp3;

internal class Program
{
    private static void Main(string[] args)
    {
        // если вторая перменная отсдеживает изменение первой => реактивный стиль

        // observer ( наблюдаталь - патерн проектирования который реализует механизм подписок)
        // это когда есть наблюдатель observer и несколько наблюдаемых observable подписанных на него
        // observeble наблюдают за всеми изменениями и каким то образом на них реагируют
        // пример: старт забега по свистку , спортсмены - наблюдатели , свисток - наблюдаемый


        //imperativeStyle();

        PaternObserver();
    }

    private static void PaternObserver()
    {
        /// реализация патерна наблюдатель
        /// работает так же как события,
        /// события плохо подаются тестированию

        /// создание
        var newsAggregator = new NewsAgrigator();
        var stive = new Reader("Stive");
        var bill = new Reader("Bill");

        /// подписка на наблюдаемое
        newsAggregator.Subscibe(stive);
        newsAggregator.Subscibe(bill);

        /// создание новостей 
        var news1 = new News("Title#1", "Content#1");
        var news2 = new News("Title#2", "Content#2");
        var news3 = new News("Title#3", "Content#3");

        /// послать уведомления
        newsAggregator.Notify(news1);
        Thread.Sleep(1000);
        newsAggregator.Notify(news2);
        Thread.Sleep(500);
        newsAggregator.UnSubscibe(bill);
        newsAggregator.Notify(news3);
    }

    /// <summary>
    /// 20 10 императивный стиль програмирование,
    //  копия переменной не отслеживает изменения первой
    /// </summary>
    public static void imperativeStyle()
    {
        Console.WriteLine("Hello, World!");

        Int32 first = 10;
        Int32 second = first;

        Console.WriteLine($"{first} {second}");
        first = 20;
        Console.WriteLine($"{first} {second}");
    }
}