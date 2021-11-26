/*
 * @description statement always evaluates to true
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE571_Expression_Always_True
{
    class CWE571_Expression_Always_True__private_return_01 : AbstractTestCase
    {
        private bool privateReturnsTrue()
        {
            return true;
        }

#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to true */
            if (privateReturnsTrue())
            {
                IO.WriteLine("always prints");
            }
        }
#endif // OMITBAD



}
}
