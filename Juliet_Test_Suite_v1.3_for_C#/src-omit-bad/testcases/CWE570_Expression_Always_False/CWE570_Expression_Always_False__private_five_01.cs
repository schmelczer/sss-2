/*
 * @description statement always evaluates to false
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE570_Expression_Always_False
{
    class CWE570_Expression_Always_False__private_five_01 : AbstractTestCase
    {
        private int privateFive = 5;



#if (!OMITGOOD)
        public override void Good()
        {
            Good1();
        }

        private void Good1()
        {
            /* FIX: may evaluate to true or false */
            if ((new Random()).Next() != privateFive)
            {
                IO.WriteLine("sometimes prints");
            }
        }
#endif // OMITGOOD

}
}
