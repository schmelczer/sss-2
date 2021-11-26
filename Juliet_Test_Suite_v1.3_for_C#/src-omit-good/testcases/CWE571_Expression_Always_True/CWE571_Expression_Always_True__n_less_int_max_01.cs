/*
 * @description statement always evaluates to true
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE571_Expression_Always_True
{
    class CWE571_Expression_Always_True__n_less_int_max_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to true */
            int intSecureRandom = (new Random()).Next();
            if (intSecureRandom < int.MaxValue)
            {
                IO.WriteLine("always prints");
            }
        }
#endif // OMITBAD



}
}
