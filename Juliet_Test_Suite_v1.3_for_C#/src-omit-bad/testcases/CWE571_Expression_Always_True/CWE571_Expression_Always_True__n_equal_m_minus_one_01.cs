/*
 * @description statement always evaluates to true
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE571_Expression_Always_True
{
    class CWE571_Expression_Always_True__n_equal_m_minus_one_01 : AbstractTestCase
    {


#if (!OMITGOOD)
        public override void Good()
        {
            Good1();
        }

        private void Good1()
        {
            int intSecureRandom1 = (new Random()).Next();
            int intSecureRandom2 = (new Random()).Next();
            /* FIX: may evaluate to true or false */
            if (intSecureRandom1 != intSecureRandom2)
            {
                IO.WriteLine("sometimes prints");
            }
        }
#endif // OMITGOOD

}
}
