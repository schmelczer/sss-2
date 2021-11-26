using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseSupport
{
    public abstract class AbstractTestCaseBadOnly : AbstractTestCaseBase
    {


        override public void RunTest(String className)
        {
            Console.WriteLine("Starting tests for Class " + className);

        }
    }
}
