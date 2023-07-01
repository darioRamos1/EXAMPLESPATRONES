using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Composite
{
    public class Composite : IComponent
    {
        private List<IComponent> _children = new List<IComponent>();

        public void Operation()
        {
            Console.WriteLine("Composite operation");
            foreach (var child in _children)
            {
                child.Operation();
            }
        }
        public void Add(IComponent component)
        {
            _children.Add(component);
        }
    }
}