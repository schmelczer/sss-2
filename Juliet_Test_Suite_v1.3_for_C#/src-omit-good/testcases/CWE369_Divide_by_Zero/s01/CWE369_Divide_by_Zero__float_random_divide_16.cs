/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_random_divide_16.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: random Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive)
* GoodSource: A hardcoded non-zero number (two)
* Sinks: divide
*    GoodSink: Check for zero before dividing
*    BadSink : Dividing by a value that may be zero
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_random_divide_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        while (true)
        {
            /* POTENTIAL FLAW: Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive) */
            Random rand = new Random();
            data = (float)rand.NextDouble();
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: Possibly divide by zero */
            int result = (int)(100.0 / data);
            IO.WriteLine(result);
            break;
        }
    }
#endif //omitbad

}
}
