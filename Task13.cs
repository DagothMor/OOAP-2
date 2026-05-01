//using System.Runtime.CompilerServices;

//namespace OOAP
//{
//    // 1. Метод публичен в родительском классе А и публичен в его потомке B;
//    public class A1
//    {
//        public A1() { }
//        public void foo() { }
//    }

//    public class B1 : A1 { }

//    // 2. метод публичен в родительском классе А и скрыт в его потомке B;
//    // К сожалению не получится. Только таким способом, не даст даже скомпилится.
//    public class A2
//    {
//        public A2() { }

//        public virtual void A2Public()
//        {
//            Console.WriteLine("Конечно я пойду с тобой на свидание.");
//        }
//    }

//    public class B2 : A2
//    {
//        public B2() { }

//        [Obsolete("Не поддерживается в этом классе.", true)]
//        public new void A2Public()
//        {
//            throw new NotImplementedException("Я сегодня занята, давай в другой раз, друг, дружище, друган, другалек.");
//        }
//    }


//    //___
//    // 3. метод скрыт в родительском классе А и публичен в его потомке B;
//    // Да, извращение, да, не оптимизировано, да, медленно, да, плохо с NAOT, но с 8 .Net уже возможно.
//    public class A3
//    {
//        public A3() { }
//        private void A3Hide()
//        {
//            Console.WriteLine("Пациент, вы как с палаты сбежали?");
//        }
//    }

//    public class B3 : A3
//    {
//        public B3() { }
//        private void B3Hide() { InstanceMethod(this); }

//        [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "A3Hide")]
//        extern static void InstanceMethod(A3 @this);
//    }

//    // 4. метод скрыт в родительском классе А и скрыт в его потомке B.

//    public class A4
//    {
//        public A4() { }
//        private protected void foo() { Console.WriteLine("Фубар"); }
//    }

//    public class B4 : A4
//    {
//        public void A4Hidden()
//        {
//            foo();
//        }

//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var sample1 = new B1();
//            sample1.foo();

//            var sample2 = new B2();
//            //sample2.A2Public();

//            var sample3 = new B3();
//            InstanceMethod(sample3);

//            var sample4 = new B4();
//            sample4.A4Hidden();


//        }
//        [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "B3Hide")]
//        extern static void InstanceMethod(B3 @this);
//    }
//}
