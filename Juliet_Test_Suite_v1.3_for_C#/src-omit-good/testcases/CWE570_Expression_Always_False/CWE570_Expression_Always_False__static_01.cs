/*
 * @description statement always evaluates to false
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE570_Expression_Always_False
{
    class CWE570_Expression_Always_False__static_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to false */
            if (IO.staticFalse)
            {
                IO.WriteLine("never prints");
            }
        }
#endif // OMITBAD



}
}
