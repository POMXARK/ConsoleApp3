using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Unsubsciber<TypeDefinition>: IDisposable
    {

        private readonly List<IObserver<TypeDefinition>> observers;
        private readonly IObserver<TypeDefinition> observer;

        public Unsubsciber(List<IObserver<TypeDefinition>> observers, IObserver<TypeDefinition> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        /// <summary>
        /// Удалить читателя из списка подписчиков
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Dispose()
        {
            if (observers.Contains(observer)) {
                observers.Remove(observer);
            }
        }
    }
}
