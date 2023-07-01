using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROXY
{
    public class RealDocument : IDocument
    {
        public void Display()
        {
            Console.WriteLine("Displaying RealDocument");
        }
    }
}
