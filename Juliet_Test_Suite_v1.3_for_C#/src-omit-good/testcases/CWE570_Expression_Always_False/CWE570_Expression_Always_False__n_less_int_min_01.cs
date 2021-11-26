/*
 * @description statement always evaluates to false
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE570_Expression_Always_False
{
    class CWE570_Expression_Always_False__n_less_int_min_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to false */
            int intSecureRandom = (new Random()).Next();
            if (intSecureRandom < int.MinValue)
            {
                IO.WriteLine("never prints");
            }
        }
#endif // OMITBAD



}
}
