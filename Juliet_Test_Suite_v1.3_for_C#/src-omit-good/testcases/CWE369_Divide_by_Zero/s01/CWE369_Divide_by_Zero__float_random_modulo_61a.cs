/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_random_modulo_61a.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: random Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive)
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_random_modulo_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data = CWE369_Divide_by_Zero__float_random_modulo_61b.BadSource();
        /* POTENTIAL FLAW: Possibly modulo by zero */
        int result = (int)(100.0 % data);
        IO.WriteLine(result);
    }
#endif //omitbad

}
}
