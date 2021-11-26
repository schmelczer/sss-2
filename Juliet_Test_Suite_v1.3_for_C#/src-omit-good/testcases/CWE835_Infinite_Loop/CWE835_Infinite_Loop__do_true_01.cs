/*
 * @description Infinite loop - do{}while(true)
 *
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE835_Infinite_Loop
{
    class CWE835_Infinite_Loop__do_true_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            int i = 0;

            /* FLAW: Infinite Loop - do..while(true) with no break point */
            do
            {
                IO.WriteLine(i);
                i++;
            } while (true);
        }
#endif // OMITBAD



}
}
