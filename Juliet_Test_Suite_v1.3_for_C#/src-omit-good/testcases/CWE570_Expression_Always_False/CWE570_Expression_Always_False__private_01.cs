/*
 * @description statement always evaluates to false
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE570_Expression_Always_False
{
    class CWE570_Expression_Always_False__private_01 : AbstractTestCase
    {
        private bool privateFalse = false;

#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to false */
            if (privateFalse)
            {
                IO.WriteLine("never prints");
            }
        }
#endif // OMITBAD



}
}
