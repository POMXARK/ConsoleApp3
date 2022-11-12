using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// observeble наблюдают за всеми изменениями и каким то образом на них реагируют
    /// </summary>
    /// <typeparam name="TypeDefinition"></typeparam>
    public interface IMyIObservable<TypeDefinition>
    {
        /// <summary>
        /// парамметр принимает подпичика
        /// подписчики определяются MyIObserver
        /// </summary>
        /// <param name="type"></param>
        void Subscribe(IMyIObserver<TypeDefinition> observer);
        void UnSubscribe(IMyIObserver<TypeDefinition> observer);

        /// <summary>
        /// Запускает процедуру уведомления всех подписчиков (observeble)
        /// парамер принимает информацию, которую нужно донести подписчику
        /// например: новость
        /// </summary>
        /// <param name="type"></param>
        void Notify(TypeDefinition data);
    }
}
