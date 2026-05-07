using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    public class Document
    {
        public int PID { get; set; }
        public FileStream openedFile { get; set; }

        public Document() { }
    }

    public class WordDocument : Document { }
    public class PdfDocument : Document { }
}
