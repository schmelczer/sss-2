/*
 * @description Explicitly throw a SystemException that will not be caught by any code.
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE248_Uncaught_Exception
{
    class CWE248_Uncaught_Exception__basic_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: Exception not caught */
            throw new SystemException("Really bad Exception");
        }
#endif // OMITBAD

        /* Override runTest for this test case so that it doesn't catch the Exception */
        public override void RunTest(string className)
        {
            IO.WriteLine("Starting tests for Class " + className);

#if (!OMITBAD)
            Bad();
            IO.WriteLine("Completed Bad() for Class " + className);
#endif // OMITBAD
        }

}
}
