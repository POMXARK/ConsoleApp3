using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Читатель, наблюдает за новосным агрегатором
    /// Эксемпляр типа News будет приходить при получении очередной новости
    /// </summary>
    public class Reader: IMyIObserver<News>
    {
        public String Name { get; set; }

        public Reader(String name)
        {
            Name = name;
        }

        public void Update(News news)
        {
            Console.WriteLine(Name);
            Console.WriteLine(news.Title);
            Console.WriteLine(news.Content);
            Console.WriteLine("-----------------");
            Console.WriteLine();
        }
    }
}
