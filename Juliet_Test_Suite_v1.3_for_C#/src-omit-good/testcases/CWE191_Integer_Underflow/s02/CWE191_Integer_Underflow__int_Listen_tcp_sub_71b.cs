/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Listen_tcp_sub_71b.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-71b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;

using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Listen_tcp_sub_71b
{
#if (!OMITBAD)
    public static void BadSink(Object dataObject )
    {
        int data = (int)dataObject;
        /* POTENTIAL FLAW: if data == int.MinValue, this will overflow */
        int result = (int)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif


}
}