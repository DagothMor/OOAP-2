using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    internal class Task7
    {
        // Reflexion
        // Не задумывался что сама семантическая единица может быть количественной мерой.

        // Это просто пример динамического получателя,напрашивается dynamic с multiple dispatch, но чувствуется что я чтото не так понял.
        static void Foo(int x) { Console.WriteLine("1"); }
        static void Foo(string x) { Console.WriteLine("2"); }
        static void Main()
        {
            dynamic x = 5;
            dynamic y = "watermelon";
            Foo(x); // 1
            Foo(y); // 2
        }


    }
}
