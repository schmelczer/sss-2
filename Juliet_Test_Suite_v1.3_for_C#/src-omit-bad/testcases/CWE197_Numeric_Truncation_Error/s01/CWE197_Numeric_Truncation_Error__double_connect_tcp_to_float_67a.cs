/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_connect_tcp_to_float_67a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_float
 *    BadSink : Convert data to a float
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__double_connect_tcp_to_float_67a : AbstractTestCase
{

    public class Container
    {
        public double containerOne;
    }

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        double data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE197_Numeric_Truncation_Error__double_connect_tcp_to_float_67b.GoodG2BSink(dataContainer  );
    }
#endif //omitgood
}
}