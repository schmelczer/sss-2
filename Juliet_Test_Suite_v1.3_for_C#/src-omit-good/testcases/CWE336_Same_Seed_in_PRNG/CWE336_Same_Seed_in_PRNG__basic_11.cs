/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE336_Same_Seed_in_PRNG__basic_11.cs
Label Definition File: CWE336_Same_Seed_in_PRNG__basic.label.xml
Template File: point-flaw-11.tmpl.cs
*/
/*
* @description
* CWE: 336 Same Seed in PRNG
* Sinks:
*    GoodSink: no explicit seed specified
*    BadSink : hardcoded seed
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE336_Same_Seed_in_PRNG
{
class CWE336_Same_Seed_in_PRNG__basic_11 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.StaticReturnsTrue())
        {
            int SEED = 10;
            /* FLAW: using the same seed can make the PRNG sequence predictable if the seed is known */
            Random random = new Random(SEED);
            IO.WriteLine("" + random.Next()); /* run this several times and notice that the bad values are always the same */
            IO.WriteLine("" + random.Next());
        }
    }
#endif //omitbad

}
}
