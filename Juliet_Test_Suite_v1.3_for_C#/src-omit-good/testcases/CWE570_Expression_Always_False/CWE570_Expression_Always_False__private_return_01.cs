/*
 * @description statement always evaluates to false
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE570_Expression_Always_False
{
    class CWE570_Expression_Always_False__private_return_01 : AbstractTestCase
    {
        private bool PrivateReturnsFalse()
        {
            return false;
        }

#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to false */
            if (PrivateReturnsFalse())
            {
                IO.WriteLine("never prints");
            }
        }
#endif // OMITBAD



}
}
