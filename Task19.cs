using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    internal class Task19
    {
        

        
    }
    // Наследование с ограничением
    public class Mage 
    {
        public int Mana { get; set; }
    }
    public class BloodMage : Mage
    {
        public int Mana = 0;

        public int HP { get; set; }
    }

    // Маг крови не может читать свитки, ибо они требуют маны а не кровь.

    // Наследование с расширением
    public class SoulStone { public int Mana { get; set; } }
    public class Staff
    {
        public string Magic { get; set; }
    }
    public class SubMachineStaff { public List<Staff> Staffs { get; set; } }
    public class DwarfMechaMage : Mage
    {
        private SoulStone mana;
        public int Mana { get { return mana.Mana; } set { mana.Mana = value; } }

        public SubMachineStaff Weapon { get; set; }
    }

    // Теперь у нас есть гном который первый в мире проявил интеллект, надел на все 21 палец кольца, надел нагрудник из ожерелий, сделал пушку из кучу посохов
    // а за спиной у него огромный кристалл который дает ману и забирает в замен души умерших врагов, но, маг ли это до сих пор? а был ли им?
}
