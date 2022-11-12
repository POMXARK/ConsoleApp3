using ConsoleApp3;
using System.Reactive.Subjects;

public static class ReativePaternSubject
{

    public static void ReactiveSubject()
    {
        // System.Reacteve (Rx.Net)

        // последовательность новостей, пока пустая
        var newsSequenсe = new Subject<News>();

        /// создание новостей 
        var news1 = new News("Title#1", "Content#1");
        var news2 = new News("Title#2", "Content#2");
        var news3 = new News("Title#3", "Content#3");
        var news4 = new News("Title#4", "Content#4");

        // публекуем значения, улетают в пустоту,
        // так как нет ни одного подписчика        
        // как и агрегатор нечего не хранит, а лишь собирает и публекует
        newsSequenсe.OnNext(news1);

        // подписываем подписчика на наблюдаемое
        var stiveSubscription = newsSequenсe.Subscribe(new ReaderV2("Steve"));

        // публекуем значения
        newsSequenсe.OnNext(news2);

        // подпишем ещё одного 
        var billSubscription = newsSequenсe.Subscribe(new ReaderV2("Bill"));

        // отписывает читателя
        stiveSubscription.Dispose();

        newsSequenсe.OnNext(news3);

        // ошибка вызовется для всех подписчиков, последовательность прервется
        newsSequenсe.OnError(new Exception("Что то пошло не так!"));

        // не публикуется
        newsSequenсe.OnNext(news4);
    }
}