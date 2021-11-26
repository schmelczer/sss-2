/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_ReadLine_divide_61a.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_ReadLine_divide_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data = CWE369_Divide_by_Zero__int_ReadLine_divide_61b.BadSource();
        /* POTENTIAL FLAW: Zero denominator will cause an issue.  An integer division will
        result in an exception. */
        IO.WriteLine("bad: 100/" + data + " = " + (100 / data) + "\n");
    }
#endif //omitbad

}
}
