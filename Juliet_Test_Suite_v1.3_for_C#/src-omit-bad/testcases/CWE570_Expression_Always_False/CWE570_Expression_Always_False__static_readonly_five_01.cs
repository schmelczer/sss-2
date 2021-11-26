/*
 * @description statement always evaluates to false
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE570_Expression_Always_False
{
    class CWE570_Expression_Always_False__static_readonly_five_01 : AbstractTestCase
    {


#if (!OMITGOOD)
        public override void Good()
        {
            Good1();
        }

        private void Good1()
        {
            /* FIX: may evaluate to true or false */
            if ((new Random()).Next() != IO.STATIC_READONLY_FIVE)
            {
                IO.WriteLine("sometimes prints");
            }
        }
#endif // OMITGOOD

}
}
