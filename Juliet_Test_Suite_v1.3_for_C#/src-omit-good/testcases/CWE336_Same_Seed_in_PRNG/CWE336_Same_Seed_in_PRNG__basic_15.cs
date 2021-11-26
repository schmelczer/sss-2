/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE336_Same_Seed_in_PRNG__basic_15.cs
Label Definition File: CWE336_Same_Seed_in_PRNG__basic.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 336 Same Seed in PRNG
* Sinks:
*    GoodSink: no explicit seed specified
*    BadSink : hardcoded seed
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE336_Same_Seed_in_PRNG
{
class CWE336_Same_Seed_in_PRNG__basic_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        switch (7)
        {
        case 7:
            int SEED = 10;
            /* FLAW: using the same seed can make the PRNG sequence predictable if the seed is known */
            Random random = new Random(SEED);
            IO.WriteLine("" + random.Next()); /* run this several times and notice that the bad values are always the same */
            IO.WriteLine("" + random.Next());
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
