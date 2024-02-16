using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    /// <summary>
    /// Абстрактный класс-потомок класса BClass
    /// </summary>
    abstract class CClass : BClass

    {
        /// <summary>
        /// Абстрактный метод приветствия
        /// </summary>
        /// <param name="hello">строка приветствия</param>
        public abstract void SayHello(string hello);


    }
}
