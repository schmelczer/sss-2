/*
 * @description Infinite loop - while(true)
 *
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE835_Infinite_Loop
{
    class CWE835_Infinite_Loop__while_true_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            int i = 0;

            /* FLAW: Infinite Loop - while(true) with no break point */
            while (true)
            {
                IO.WriteLine(i);
                i++;
            }
        }
#endif // OMITBAD



}
}
