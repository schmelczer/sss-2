/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_NetClient_to_byte_45.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_NetClient_to_byte_45 : AbstractTestCase
{

    private long dataBad;
    private long dataGoodG2B;

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    private void GoodG2BSink()
    {
        long data = dataGoodG2B;
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        long data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        dataGoodG2B = data;
        GoodG2BSink();
    }
#endif //omitgood
}
}
