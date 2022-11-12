
namespace ConsoleApp3
{
    /// <summary>
    /// Читатель, наблюдает за новосным агрегатором
    /// Эксемпляр типа News будет приходить при получении очередной новости
    /// </summary>
    public class ReaderV2: IObserver<News>
    {
        public String Name { get; set; }

        public ReaderV2(String name)
        {
            Name = name;
        }

        /// <summary>
        /// Вызывается, если агрегатор больше не будет высылать не каких уведомлений
        /// </summary>
        public void OnCompleted()
        {
        }

        /// <summary>
        /// Будет вызван если случился сбой, ошибка
        /// </summary>
        /// <param name="error"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(error.ToString());
            Console.ResetColor();
        }

        /// <summary>
        /// похож на самописный Update()
        /// Будет вызван когда в агрегатор поступит новая новость
        /// Будет выслано уведомление читателю, новость в качестве параметра
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnNext(News value)
        {
            Console.WriteLine(Name);
            Console.WriteLine(value.Title);
            Console.WriteLine(value.Content);
            Console.WriteLine("-----------------");
            Console.WriteLine();
        }
    }
}
