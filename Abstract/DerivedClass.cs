using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    /// <summary>
    /// Обычный класс-потомок класса CClass
    /// </summary>
    class DerivedClass : CClass
    {
        /// <summary>
        /// Переопределённый метод из класса AClass
        /// </summary>
        public override void Method()
        {
           
        }
        /// <summary>
        /// Переопределённый метод суммирования из класса BClass
        /// </summary>
        /// <param name="a">число a</param>
        /// <param name="b">число b</param>
        /// <returns></returns>
        public override int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Переопределённый метод приветствия из класса CClass
        /// </summary>
        /// <param name="hello">строка приветствия</param>
        /// <returns></returns>
        public override void SayHello(string hello)
        {
            Console.WriteLine(hello);
        }
        /// <summary>
        /// Обычный метод приветствия
        /// </summary>
        /// <param name="hello">строка приветствия</param>
        public void SayHello1(string hello)
        {
            Console.WriteLine(hello);
        }




    }
}
