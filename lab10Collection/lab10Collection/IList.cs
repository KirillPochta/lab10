using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10Collection
{
    interface IList<T>
    {
        public void Repair();
        public void Build();
        public void Execute();
    }
}
