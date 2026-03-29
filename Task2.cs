using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    internal class Task2
    {
    }

    // Reflexion
    /// <summary>
    /// У меня такие же примеры как у остальных, не над чем рефлексировать :^)
    /// </summary>

    public class Signature
    {
        public byte[] sign { get; set; }
    }
    public class Document
    {
        public Signature Signature { get; set; }
    }

    //                               |Расширение класса родителя усиленной цифровой подписью|.
    public class Contract : Document, IEnchancedSign
    {
        // Специализация класса родителя, добавление подписи внешней стороны.
        public Signature SignatureOfOtherSide { get; set; }
    }

    public interface IEnchancedSign
    {
        public void SignWithStrongCaption(Signature signature, byte[] GOST)
        {
            signature.sign = GOST;
        }
    }
}
