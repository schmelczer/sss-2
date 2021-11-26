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


#if (!OMITGOOD)
        public override void Good()
        {
            Good1();
        }

        private void Good1()
        {
            int intSecureRandom = (new Random()).Next();
            /* FIX: may evaluate to true or false */
            if (intSecureRandom < 5000)
            {
                IO.WriteLine("sometimes prints");
            }
        }
#endif // OMITGOOD

}
}
