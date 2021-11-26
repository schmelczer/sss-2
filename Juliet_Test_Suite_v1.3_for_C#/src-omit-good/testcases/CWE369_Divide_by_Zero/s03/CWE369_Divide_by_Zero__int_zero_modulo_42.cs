/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_zero_modulo_42.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: zero Set data to a hardcoded value of zero
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_zero_modulo_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static int BadSource()
    {
        int data;
        data = 0; /* POTENTIAL FLAW: data is set to zero */
        return data;
    }

    public override void Bad()
    {
        int data = BadSource();
        /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
        result in an exception.  */
        IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
    }
#endif //omitbad

}
}
