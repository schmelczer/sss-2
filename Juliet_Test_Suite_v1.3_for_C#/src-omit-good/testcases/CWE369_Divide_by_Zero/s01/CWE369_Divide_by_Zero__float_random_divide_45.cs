/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_random_divide_45.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: random Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive)
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_random_divide_45 : AbstractTestCase
{

    private float dataBad;
    private float dataGoodG2B;
    private float dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        float data = dataBad;
        /* POTENTIAL FLAW: Possibly divide by zero */
        int result = (int)(100.0 / data);
        IO.WriteLine(result);
    }

    public override void Bad()
    {
        float data;
        /* POTENTIAL FLAW: Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive) */
        Random rand = new Random();
        data = (float)rand.NextDouble();
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
