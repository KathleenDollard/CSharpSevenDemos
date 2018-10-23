using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
    public class Role<T>  
    {
        public Role(T underlying) =>
            Underlying = underlying;

       public T Underlying { get; }
    }
}
