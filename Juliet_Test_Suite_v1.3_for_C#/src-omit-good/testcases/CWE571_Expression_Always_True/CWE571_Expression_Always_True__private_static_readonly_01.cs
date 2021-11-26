/*
 * @description statement always evaluates to true
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE571_Expression_Always_True
{
    class CWE571_Expression_Always_True__private_static_readonly_01 : AbstractTestCase
    {
        private static readonly bool PRIVATE_STATIC_READONLY_TRUE = true;

#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to true */
            if (PRIVATE_STATIC_READONLY_TRUE)
            {
                IO.WriteLine("always prints");
            }
        }
#endif // OMITBAD



}
}
