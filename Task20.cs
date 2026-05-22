using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    //Рефлексия:
    // Примеры подобрал правильные.

    // Наследования вариаций
    public class Animal
    {
        public virtual void MakeSound() { }

    }

    public class Cat1 : Animal
    {
        public override void MakeSound() { Console.WriteLine("Meow"); }

    }

    // Наследование с конкретизацией (reification inheritance)

    public abstract class Document1
    {
        public abstract void Signing();
    }

    public class Contract1 : Document1
    {
        public override void Signing()
        {
        }
    }

    public class SupAgreement1 : Document1
    {
        public Contract1 Contract { get; set; }
        public override void Signing()
        {
        }
    }

    // Наследование с конкретизацией (reification inheritance)
    public class Monkeys : IEnumerable<Monkey>
}
