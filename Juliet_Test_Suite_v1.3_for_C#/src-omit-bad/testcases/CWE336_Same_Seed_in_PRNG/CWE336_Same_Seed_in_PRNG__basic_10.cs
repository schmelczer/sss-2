/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE336_Same_Seed_in_PRNG__basic_10.cs
Label Definition File: CWE336_Same_Seed_in_PRNG__basic.label.xml
Template File: point-flaw-10.tmpl.cs
*/
/*
* @description
* CWE: 336 Same Seed in PRNG
* Sinks:
*    GoodSink: no explicit seed specified
*    BadSink : hardcoded seed
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE336_Same_Seed_in_PRNG
{
class CWE336_Same_Seed_in_PRNG__basic_10 : AbstractTestCase
{

#if (!OMITGOOD)
    /* good1() changes IO.staticTrue to IO.staticFalse */
    private void Good1()
    {
        if (IO.staticFalse)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            Random random = new Random();
            /* FIX: no explicit seed specified; produces far less predictable PRNG sequence */
            IO.WriteLine("" + random.Next());
            IO.WriteLine("" + random.Next());
        }
    }

    /* good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (IO.staticTrue)
        {
            Random random = new Random();
            /* FIX: no explicit seed specified; produces far less predictable PRNG sequence */
            IO.WriteLine("" + random.Next());
            IO.WriteLine("" + random.Next());
        }
    }

    public override void Good()
    {
        Good1();
        Good2();
    }
#endif //omitgood
}
}
