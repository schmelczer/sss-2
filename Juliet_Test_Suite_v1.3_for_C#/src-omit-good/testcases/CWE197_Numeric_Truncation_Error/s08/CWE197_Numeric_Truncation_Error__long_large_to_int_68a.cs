/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_large_to_int_68a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than int.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * BadSink: to_int Convert data to a int
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_large_to_int_68a : AbstractTestCase
{

    public static long data;
#if (!OMITBAD)
    public override void Bad()
    {
        /* FLAW: Use a number larger than int.MaxValue */
        data = int.MaxValue + 5L;
        CWE197_Numeric_Truncation_Error__long_large_to_int_68b.BadSink();
    }
#endif //omitbad

}
}
