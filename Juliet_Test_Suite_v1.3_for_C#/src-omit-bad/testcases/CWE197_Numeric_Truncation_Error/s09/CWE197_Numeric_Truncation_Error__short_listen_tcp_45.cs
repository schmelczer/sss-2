/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__short_listen_tcp_45.cs
Label Definition File: CWE197_Numeric_Truncation_Error__short.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__short_listen_tcp_45 : AbstractTestCase
{

    private short dataBad;
    private short dataGoodG2B;

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    private void GoodG2BSink()
    {
        short data = dataGoodG2B;
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        short data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        dataGoodG2B = data;
        GoodG2BSink();
    }
#endif //omitgood
}
}
