/*
 * @description statement always evaluates to false
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE570_Expression_Always_False
{
    class CWE570_Expression_Always_False__n_equal_n_minus_one_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to false */
            int intThirty = 30;

            if (intThirty == (intThirty - 1))
            {
                IO.WriteLine("never prints");
            }
        }
#endif // OMITBAD



}
}
