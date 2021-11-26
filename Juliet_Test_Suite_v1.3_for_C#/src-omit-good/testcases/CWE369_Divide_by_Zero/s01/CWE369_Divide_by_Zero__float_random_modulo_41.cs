/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_random_modulo_41.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: random Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive)
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_random_modulo_41 : AbstractTestCase
{
#if (!OMITBAD)
    private static void BadSink(float data )
    {
        /* POTENTIAL FLAW: Possibly modulo by zero */
        int result = (int)(100.0 % data);
        IO.WriteLine(result);
    }

    public override void Bad()
    {
        float data;
        /* POTENTIAL FLAW: Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive) */
        Random rand = new Random();
        data = (float)rand.NextDouble();
        BadSink(data  );
    }
#endif //omitbad

}
}
