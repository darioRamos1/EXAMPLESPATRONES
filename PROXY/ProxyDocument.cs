using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROXY
{
    public class ProxyDocument : IDocument
    {
        private RealDocument realDocument;

        public void Display()
        {
            if (realDocument == null)
            {
                realDocument = new RealDocument();
            }
            realDocument.Display();
        }
    }
}
