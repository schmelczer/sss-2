/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_large_to_int_53a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-53a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than int.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_int
 *    BadSink : Convert data to a int
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_large_to_int_53a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        /* FLAW: Use a number larger than int.MaxValue */
        data = int.MaxValue + 5L;
        CWE197_Numeric_Truncation_Error__long_large_to_int_53b.BadSink(data );
    }
#endif //omitbad

}
}
