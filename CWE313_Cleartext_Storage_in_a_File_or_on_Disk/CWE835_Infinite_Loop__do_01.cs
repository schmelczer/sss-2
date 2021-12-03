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


#if (!OMITGOOD)
        private void Good1()
        {
            int i = 0;

            do
            {
                /* FIX: Add a break point for the loop if i = 10 */
                if (i == 10)
                {
                    break;
                }
                IO.WriteLine(i);
                i = (i + 1) % 256;
            } while (i >= 0);
        }

        public override void Good()
        {
            Good1();
        }
#endif // OMITGOOD

}
}
