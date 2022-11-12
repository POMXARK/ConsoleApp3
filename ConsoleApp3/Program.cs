using ConsoleApp3;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;

internal class Program
{
    private static void Main(string[] args)
    {
        // если вторая перменная отсдеживает изменение первой => реактивный стиль

        // наблюдаемая последовательность это контейнер ( шаблон строитель, но четко упорядоченный)
        // пример: по дял работы с финансовыми биржами, на вход много информации, пользователь желает получить некую выжемку
        // выжемка должна автаматически обновляться в реальном времени в зависимости от изменений на рынках
        // решение: организовать последовательность блоков информации которые приходят с бирж
        // в реальном времени фильтровать, сортировать и агрегировать необходимым образом
        // и при поступлении каждого нового блока данных, необходимо тут же прогонять через весь конвеер из агрегаторов, сортировщиков и фильтров
        // выдавать пользователю лишь конечный результат



        //imperativeStyle();

        //PaternsObserver.CastomPaternObserver();

        //PaternsObserver.PaternObserver();


        //ReativePaternSubject.ReactiveSubject();



        //observableReturn();

        ReactivePaternObservable.ObservableCreate();

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