/*
 * @description statement always evaluates to false
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE570_Expression_Always_False
{
    class CWE570_Expression_Always_False__private_static_readonly_01 : AbstractTestCase
    {
        private static readonly bool PRIVATE_STATIC_READONLY_FALSE = false;

#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to false */
            if (PRIVATE_STATIC_READONLY_FALSE)
            {
                IO.WriteLine("never prints");
            }
        }
#endif // OMITBAD



}
}
