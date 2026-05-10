using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    public class Task16
    {
        public void Start()
        {
            var cat = new Cat();

            var supAbsCat = cat as SuperAbstractCat;

            supAbsCat.Purr();

            var supCat = supAbsCat as Cat;

            supCat.Meow();
            supCat.Purr();
        }
    }
    public interface IPurrable { public void Purr(); }
    public class SuperAbstractCat : IPurrable { public virtual void Meow() { Console.WriteLine("Super Abstract Meow"); } public void Purr() { Console.WriteLine("Super Abstract Purr"); } }
    public class AbstractCat : SuperAbstractCat { }
    public class Cat : AbstractCat
    {
        public override void Meow() { Console.WriteLine("Real Meow"); }
        public new void Purr() { Console.WriteLine("Real Purr"); }
    }
}
