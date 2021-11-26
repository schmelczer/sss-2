/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_listen_tcp_to_int_61b.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_int
 *    BadSink : Convert data to a int
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_listen_tcp_to_int_61b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static float GoodG2BSource()
    {
        float data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        return data;
    }
#endif
}
}
