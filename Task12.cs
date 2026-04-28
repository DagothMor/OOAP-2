using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace OOAP
{
    
    public class General1 
    {
        // Пример прямого:
        // Можем определять только конкретные случаи.
        public static explicit operator General1(byte b)
        {
            Any1 d = new Any1(b);
            return d;
        }

        // Есть такой вариант
        public bool TryCast<T>(this object obj, out T result)
        {
            if (obj is T)
            {
                result = (T)obj;
                return true;
            }

            result = default(T);
            return false;
        }

        // В основном мы пользуемся is as.
    }
    public class Any1 : General1 
    {
        public byte B { get; }

        public Any1(byte b)
        {
            B = b;
        }

        public static explicit operator Any1(byte b)  
        {
            Any1 d = new Any1(b);
            return d;
        }

    }

    class TestExplicitConversion
    {
        static void Main()
        {
            try
            {
                byte b = 3;
                Any1 d = (Any1)b;  // explicit conversion
            }
            catch (System.Exception e)
            {
                //...
            }
        }
    }



}
