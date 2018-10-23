using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
    public interface ISalutation
    {
        string Opening { get; }
    }

    public interface IEndOfTermMessageInfo
    {
        string ThankYouMessage { get; }
        string Closing { get; }
    }
}
