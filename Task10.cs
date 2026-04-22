using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    public class Parent
    {
        public virtual void Display() { }
    }
    public class Child : Parent
    {
        // Переопределяем и запечатываем
        public sealed override void Display() { }
    }

    public class GrandChild : Child
    {
        // Ошибка билда, пытаемся переопределить запечатанный метод.
        public sealed override void Display() { }
    }
}
