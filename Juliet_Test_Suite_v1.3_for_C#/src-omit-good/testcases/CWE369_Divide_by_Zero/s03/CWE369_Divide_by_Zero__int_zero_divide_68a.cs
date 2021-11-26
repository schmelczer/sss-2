/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_zero_divide_68a.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: zero Set data to a hardcoded value of zero
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_zero_divide_68a : AbstractTestCase
{

    public static int data;
#if (!OMITBAD)
    public override void Bad()
    {
        data = 0; /* POTENTIAL FLAW: data is set to zero */
        CWE369_Divide_by_Zero__int_zero_divide_68b.BadSink();
    }
#endif //omitbad

}
}