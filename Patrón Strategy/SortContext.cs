using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy
{
    public class SortContext
    {
        private ISortStrategy _strategy;

        public SortContext(ISortStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void Sort(int[] dataset)
        {
            _strategy.Sort(dataset);
        }
    }
}
