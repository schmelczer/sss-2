/*
 * @description Infinite loop - do{}while()
 *
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE835_Infinite_Loop
{
    class CWE835_Infinite_Loop__do_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            int i = 0;

            /* FLAW: Infinite Loop - do..while() with no break point */
            do
            {
                IO.WriteLine(i);
                i = (i + 1) % 256;
            } while (i >= 0);
        }
#endif // OMITBAD



}
}
