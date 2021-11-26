/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__short_large_51a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__short.label.xml
Template File: sources-sink-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than byte.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * BadSink: to_byte Convert data to a byte
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__short_large_51a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        /* FLAW: Use a number larger than byte.MaxValue */
        data = byte.MaxValue + 5;
        CWE197_Numeric_Truncation_Error__short_large_51b.BadSink(data  );
    }
#endif //omitbad

}
}
