/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__int_large_to_byte_54a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__int.label.xml
Template File: sources-sink-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than short.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__int_large_to_byte_54a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        /* FLAW: Use a number larger than short.MaxValue */
        data = short.MaxValue + 5;
        CWE197_Numeric_Truncation_Error__int_large_to_byte_54b.BadSink(data );
    }
#endif //omitbad

}
}
