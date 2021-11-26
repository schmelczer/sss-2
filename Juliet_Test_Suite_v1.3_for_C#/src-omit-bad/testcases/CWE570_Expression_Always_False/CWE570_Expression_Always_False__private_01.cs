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



#if (!OMITGOOD)
        public override void Good()
        {
            Good1();
        }

        private void Good1()
        {
            /* FIX: may evaluate to true or false */
            if (IO.StaticReturnsTrueOrFalse() == privateFalse)
            {
                IO.WriteLine("sometimes prints");
            }
        }
#endif // OMITGOOD

}
}
