using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// observe ( наблюдаталь - патерн проектирования который реализует механизм подписок)
    /// </summary>
    /// <typeparam name="TypeDefinition"></typeparam>
    public interface IObserver<TypeDefinition>
    {
        /// <summary>
        /// Этот метод будет вызываться, 
        /// когда наблюдатель (observable) получает уведомление
        /// Пример: агрегатор новостей ( агрегатор, подписчики - наблюдатели (читатели))
        /// читатели получают уведомление от агрегатора при появлении новой новости
        /// факт того что появилась новость хорошо бы сопроваждать ссылкой или самой новостью , параметр data отвечает за это 
        /// </summary>
        /// <param name="data"></param>
       void Update(TypeDefinition data);
    }
}
