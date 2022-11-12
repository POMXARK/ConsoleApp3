using System.Reactive.Disposables;
using System.Reactive.Linq;

/// <summary>
/// Оbserveble содержит ряд фабричных методов, которые способны генерировать последовательности
/// </summary>
public static class ReactivePaternObservable
{

    public static void ObservableCreate()
    {
        // Ленивые вычисления? , оптимезирован по производительности
        var observable =
            Observable
                .Create<String>(subscribe: observer =>
                {
                    observer.OnNext("Привет, Мир!");
                    observer.OnNext("Ставь лайк!");
                    observer.OnNext("Подписывайся на канал!");
                    observer.OnCompleted();
                    return Disposable.Empty;
                });

        var subscription =
            observable
                .Subscribe(onNext: Console.WriteLine,
                            onError: exception =>
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine(exception.Message);
                                Console.ResetColor();
                            },
                            onCompleted: () => Console.WriteLine("Последовательность завершена"));

        //observable.Subscribe(onNext: Console.WriteLine);
    }

    public static void observableReturn()
    {
        // возвращает последовательность, которая публекует значение и после этого завершается
        // принимает значение, которое будет опубликованно
        var observable = Observable.Return("Hello, World!");

        //var subscription = observable.Subscribe(x => Console.WriteLine(x));
        // или так
        var subscription = observable.Subscribe(Console.WriteLine);
    }
}