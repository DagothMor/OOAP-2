using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    // Написал свой Black souls...
    public abstract class RelationShip
    {
        // И много чего еще можно интересного сделать в типикал HJRPG, Наверно стоило бы еще и Kiss и Service выделить в отдельные классы, родитель которых Action.
        public virtual void Kiss(NPC npc)
        {

        }
        public virtual void Service(NPC npc)
        {

        }
    }
    public class Covenant : RelationShip
    {
        public override void Kiss(NPC npc)
        {
            switch (npc)
            {
                case RedHood redHood:
                    redHood.GrimmProfession.Kiss(redHood);
                    break;
                case Node node:
                    node.GrimmProfession.Kiss(node);
                    break;
                default:
                    break;
            }
        }
        public override void Service(NPC npc)
        {
            switch (npc)
            {
                case RedHood redHood:
                    redHood.GrimmProfession.Service(redHood);
                    break;
                case Node node:
                    node.GrimmProfession.Service(node);
                    break;
                default:
                    break;
            }
        }
    }

    public class NotInRelationship : RelationShip
    {
        public void Kiss(RedHood redHood)
        {
            Console.WriteLine("FAQ off");
        }

        public void Service(RedHood redHood)
        {
            Console.WriteLine("You are not Poro.");
        }
        public void Kiss(Node redHood)
        {
            Console.WriteLine("Oh...So embrassing!");
        }
        public void Service(Node redHood)
        {
            Console.WriteLine("Oh...So embrassing!");
        }
        
    }
    public class Concubine : RelationShip
    {

    }

    #region Profession
    public abstract class Profession
    {
        public virtual void Kiss(NPC npc) { }
        public virtual void Service(NPC npc) { }
    }

    public class Tank : Profession
    {
        public override void Kiss(NPC npc)
        {
            switch (npc)
            {
                case RedHood redHood:
                    Console.WriteLine("My helmet is stuck, not now.");
                    break;
                case Node node:
                    Console.WriteLine("Of course Lord Grimm.");
                    break;
                default:
                    break;
            }
        }

        public override void Service(NPC npc)
        {
            switch (npc)
            {
                case RedHood redHood:
                    Console.WriteLine("How do you think I'm going to take off this armor now?");
                    break;
                case Node node:
                    Console.WriteLine("Of course Lord Grimm.");
                    break;
                default:
                    break;
            }
        }
    }
    public class Cook : Profession { }
    public class Healer : Profession { }
    public class NightService : Profession { }
    public class NONEPROFESSION : Profession { }
    #endregion

    public abstract class Character
    {
        public int Hp { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
    }
    // Для каждого npc может быть свой сценарий взаимодействия с главным героем, и комбинаций состояний могут быть несколько.
    public class NPC : Character
    {
        public RelationShip GrimmRelationShip { get; set; }
        public Profession GrimmProfession { get; set; }

        public virtual void Kiss()
        {
            // Пример начала обработки варианта событий.
            // Думаю это лаконичнее чем то,что написано в rpg maker vx ace.
            GrimmRelationShip.Kiss(this);
        }

        public virtual void Service()
        {
            GrimmRelationShip.Kiss(this);
        }
    }

    public class Grimm : Character
    {
        public int Souls { get; set; }
    }
    public class RedHood : NPC { }
    // Крольчиха Нод.
    public class Node : NPC { }
    public class TheCrawlingOne : NPC { }
    public class Alice : TheCrawlingOne { }
    public class SisterAlice : TheCrawlingOne { }
    public class MotherAlice : TheCrawlingOne { }
    public class DaughterAlice : TheCrawlingOne { }
    public class Prikett : Alice { }
    public class Victoria : NPC { }
}
