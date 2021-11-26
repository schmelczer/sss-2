/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_listen_tcp_to_long_45.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_long
 *    BadSink : Convert data to a long
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

class CWE197_Numeric_Truncation_Error__double_listen_tcp_to_long_45 : AbstractTestCase
{

    private double dataBad;
    private double dataGoodG2B;

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    private void GoodG2BSink()
    {
        double data = dataGoodG2B;
        {
            /* POTENTIAL FLAW: Convert data to a long, possibly causing a truncation error */
            IO.WriteLine((long)data);
        }
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        double data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        dataGoodG2B = data;
        GoodG2BSink();
    }
#endif //omitgood
}
}
