using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Classes
{
    public class MyClass
    {
        private string? str;

        public MyClass(string? str)
        {
            this.str = str;
        }

        public void Space(string str)

        {
            char[] new_str = str.ToCharArray();
            for (int i = 0; i < new_str.Length; i++)
            {
                Console.Write($"{new_str[i]}");
                if(i !=  new_str.Length - 1) {  Console.Write('_'); }
            }
            Console.WriteLine();
        }
        public void Reverse(string str)
        {
            char[] new_str = str.ToCharArray();
            for (int i = str.Length - 1; i >= 0; i--)
                Console.Write(new_str[i]);

            Console.WriteLine();

        }

    }
}
