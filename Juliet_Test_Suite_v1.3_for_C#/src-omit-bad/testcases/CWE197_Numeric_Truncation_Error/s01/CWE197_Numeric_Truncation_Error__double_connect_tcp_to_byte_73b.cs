/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_connect_tcp_to_byte_73b.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__double_connect_tcp_to_byte_73b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(LinkedList<double> dataLinkedList )
    {
        double data = dataLinkedList.Last.Value;
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }
#endif
}
}