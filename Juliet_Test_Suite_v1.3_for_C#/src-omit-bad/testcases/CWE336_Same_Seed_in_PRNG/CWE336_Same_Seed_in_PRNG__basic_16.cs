/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE336_Same_Seed_in_PRNG__basic_16.cs
Label Definition File: CWE336_Same_Seed_in_PRNG__basic.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 336 Same Seed in PRNG
* Sinks:
*    GoodSink: no explicit seed specified
*    BadSink : hardcoded seed
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE336_Same_Seed_in_PRNG
{
class CWE336_Same_Seed_in_PRNG__basic_16 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() change the conditions on the while statements */
    private void Good1()
    {
        while(true)
        {
            Random random = new Random();
            /* FIX: no explicit seed specified; produces far less predictable PRNG sequence */
            IO.WriteLine("" + random.Next());
            IO.WriteLine("" + random.Next());
            break;
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}
