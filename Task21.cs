using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{


    // implementation inheritance
    // Монстр Сколопендра унаследовала функции класса Список.
    // Теперь, чтобы убить ее, значение головы, или всего тела должны быть равны 0
    public class Scolopendra : List<int>
    {

    }

    // facility inheritance
    class Zero
    {
        public Zero() { }
        public virtual void Fatality()
        {
            Console.WriteLine("Скучная анимация добивания противника");
        }
    }

    class SubZero : Zero
    {
        public SubZero() { }
        public override void Fatality()
        {
            Console.WriteLine("Ледяная анимация добивания противника");
        }
    }

    class Scorpion : Zero
    {
        public Scorpion() { }
        public override void Fatality()
        {
            Console.WriteLine("Огненная анимация добивания противника и признание в любви к SubZero");
        }
    }
}
