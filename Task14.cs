using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    public class Vector<T> : General 
    {
        public T Vectors { get; set; }         
        public Vector() { }

        public Vector(T value) { }

        // Как то так должно быть
        public static Vector<T> operator +(Vector<T> a, Vector<T> b)
        {

            if (a is null || b is null)
            {

            }
            if (GetListType(a.GetType()) is ICollection && GetListType(b.GetType()) is ICollection)
            {
                var thisVec = a.Vectors as List<T>;

                var otherVec = b.Vectors as List<T>;

                if(thisVec.Count != otherVec.Count)
                {
                    return null;
                }

                if (thisVec.First().GetType() is ICollection)
                {
                    return a + b;
                }
                for (int i = 0; i < thisVec.Count; i++) 
                {
                    
                }
            }
        }

        static Type GetListType(Type type)
        {
            foreach (Type intType in type.GetInterfaces())
            {
                if (intType.IsGenericType
                    && intType.GetGenericTypeDefinition() == typeof(IList<>))
                {
                    return intType.GetGenericArguments()[0];
                }
            }
            return null;
        }

    }
}
