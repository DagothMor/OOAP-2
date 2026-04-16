using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    // Reflexion:
    // Все же это была таблица override, все так просто...

    // Пример Ковариантности
    public class B1 { }
    public class B2 : B1 { }
    public class A1
    {
        public virtual B1 Foo()
        {
            return new B1();
        }
    }

    public class A2 : A1
    {
        public override B2 Foo() {
            return new B2();
        }
    }

    //________________________________________

    // Не смог придумать пример Контрвариантности
}
