/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__short_large_45.cs
Label Definition File: CWE197_Numeric_Truncation_Error__short.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than byte.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__short_large_45 : AbstractTestCase
{

    private short dataBad;
    private short dataGoodG2B;
#if (!OMITBAD)
    private void BadSink()
    {
        short data = dataBad;
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }

    /* uses badsource and badsink */
    public override void Bad()
    {
        short data;
        /* FLAW: Use a number larger than byte.MaxValue */
        data = byte.MaxValue + 5;
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
