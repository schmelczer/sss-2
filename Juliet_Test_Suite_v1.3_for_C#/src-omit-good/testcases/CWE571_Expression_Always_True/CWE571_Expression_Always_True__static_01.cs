/*
 * @description statement always evaluates to true
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE571_Expression_Always_True
{
    class CWE571_Expression_Always_True__static_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to true */
            if (IO.staticTrue)
            {
                IO.WriteLine("always prints");
            }
        }
#endif // OMITBAD



}
}
