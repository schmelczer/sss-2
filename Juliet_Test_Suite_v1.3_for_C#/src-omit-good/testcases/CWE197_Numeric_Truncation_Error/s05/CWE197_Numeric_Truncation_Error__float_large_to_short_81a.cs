/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_large_to_short_81a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than long.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_short
 *    BadSink : Convert data to a short
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_large_to_short_81a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        /* FLAW: Use a number larger than short.MaxValue */
        data = long.MaxValue + 5f;
        CWE197_Numeric_Truncation_Error__float_large_to_short_81_base baseObject = new CWE197_Numeric_Truncation_Error__float_large_to_short_81_bad();
        baseObject.Action(data );
    }
#endif //omitbad

}
}
