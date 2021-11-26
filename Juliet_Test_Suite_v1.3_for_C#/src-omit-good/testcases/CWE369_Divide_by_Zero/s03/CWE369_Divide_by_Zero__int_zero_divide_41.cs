/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_zero_divide_41.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: zero Set data to a hardcoded value of zero
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_zero_divide_41 : AbstractTestCase
{
#if (!OMITBAD)
    private static void BadSink(int data )
    {
        /* POTENTIAL FLAW: Zero denominator will cause an issue.  An integer division will
        result in an exception. */
        IO.WriteLine("bad: 100/" + data + " = " + (100 / data) + "\n");
    }

    public override void Bad()
    {
        int data;
        data = 0; /* POTENTIAL FLAW: data is set to zero */
        BadSink(data  );
    }
#endif //omitbad

}
}
