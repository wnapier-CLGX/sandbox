using System;
using System.Linq;

namespace sandbox.domain
{
    public class Class1
    {
        public string Foo(string Bar)
        {
            return Bar.ToArray().Reverse().ToString();
        }
    }
}
