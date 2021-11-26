/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_random_divide_01.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-01.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: random Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive)
* GoodSource: A hardcoded non-zero number (two)
* Sinks: divide
*    GoodSink: Check for zero before dividing
*    BadSink : Dividing by a value that may be zero
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_random_divide_01 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        /* POTENTIAL FLAW: Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive) */
        Random rand = new Random();
        data = (float)rand.NextDouble();
        /* POTENTIAL FLAW: Possibly divide by zero */
        int result = (int)(100.0 / data);
        IO.WriteLine(result);
    }
#endif //omitbad

}
}
