using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseSupport
{
    public abstract class AbstractTestCaseClassIssueBad : AbstractTestCaseBase, ICloneable
    {

        public abstract object Clone();

        public override void RunTest(string className)
        {
            Console.WriteLine("Starting tests for Class " + className);

        }
    }
}
