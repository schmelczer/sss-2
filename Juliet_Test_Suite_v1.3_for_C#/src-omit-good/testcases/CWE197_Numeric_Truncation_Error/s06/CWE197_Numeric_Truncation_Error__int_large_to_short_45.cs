/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__int_large_to_short_45.cs
Label Definition File: CWE197_Numeric_Truncation_Error__int.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than short.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_short
 *    BadSink : Convert data to a short
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__int_large_to_short_45 : AbstractTestCase
{

    private int dataBad;
    private int dataGoodG2B;
#if (!OMITBAD)
    private void BadSink()
    {
        int data = dataBad;
        {
            /* POTENTIAL FLAW: Convert data to a short, possibly causing a truncation error */
            IO.WriteLine((short)data);
        }
    }

    /* uses badsource and badsink */
    public override void Bad()
    {
        int data;
        /* FLAW: Use a number larger than short.MaxValue */
        data = short.MaxValue + 5;
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
