/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__short_large_41.cs
Label Definition File: CWE197_Numeric_Truncation_Error__short.label.xml
Template File: sources-sink-41.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than byte.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * BadSink: to_byte Convert data to a byte
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__short_large_41 : AbstractTestCase
{
#if (!OMITBAD)
    private static void BadSink(short data )
    {
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }

    public override void Bad()
    {
        short data;
        /* FLAW: Use a number larger than byte.MaxValue */
        data = byte.MaxValue + 5;
        BadSink(data  );
    }
#endif //omitbad

}
}
