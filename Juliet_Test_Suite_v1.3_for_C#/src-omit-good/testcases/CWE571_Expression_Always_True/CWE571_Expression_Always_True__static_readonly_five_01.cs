/*
 * @description statement always evaluates to true
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE571_Expression_Always_True
{
    class CWE571_Expression_Always_True__static_readonly_five_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to true */
            if (IO.STATIC_READONLY_FIVE == 5)
            {
                IO.WriteLine("always prints");
            }
        }
#endif // OMITBAD



}
}
