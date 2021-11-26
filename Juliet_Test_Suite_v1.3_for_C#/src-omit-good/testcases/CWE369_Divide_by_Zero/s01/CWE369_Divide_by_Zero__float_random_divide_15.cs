/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_random_divide_15.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: random Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive)
* GoodSource: A hardcoded non-zero number (two)
* Sinks: divide
*    GoodSink: Check for zero before dividing
*    BadSink : Dividing by a value that may be zero
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_random_divide_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        switch (6)
        {
        case 6:
            /* POTENTIAL FLAW: Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive) */
            Random rand = new Random();
            data = (float)rand.NextDouble();
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0.0f;
            break;
        }
        switch (7)
        {
        case 7:
            /* POTENTIAL FLAW: Possibly divide by zero */
            int result = (int)(100.0 / data);
            IO.WriteLine(result);
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
