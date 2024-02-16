using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    /// <summary>
    /// Абстрактный класс-потомок класса AClass
    /// </summary>
    abstract class BClass : AClass
    {
        /// <summary>
        /// Абстрактный метод Sum с двумя параметрами
        /// </summary>
        /// <param name="a">число a</param>
        /// <param name="b">число b</param>
        /// <returns></returns>
        public abstract int Sum(int a, int b);


      
    }
}
