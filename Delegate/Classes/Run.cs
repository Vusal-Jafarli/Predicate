using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Classes
{
 
    public class Run
    {
        public void runFunc(Func func, string str)
        {
            func.Function.Invoke(str);
        }

    }
}
