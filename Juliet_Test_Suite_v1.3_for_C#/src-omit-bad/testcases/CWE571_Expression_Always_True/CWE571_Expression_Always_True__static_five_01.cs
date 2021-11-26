/*
 * @description statement always evaluates to true
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE571_Expression_Always_True
{
    class CWE571_Expression_Always_True__static_five_01 : AbstractTestCase
    {


#if (!OMITGOOD)
        public override void Good()
        {
            Good1();
        }

        private void Good1()
        {
            /* FIX: may evaluate to true or false */
            if ((new Random()).Next() == IO.staticFive)
            {
                IO.WriteLine("sometimes prints");
            }
        }
#endif // OMITGOOD

}
}
