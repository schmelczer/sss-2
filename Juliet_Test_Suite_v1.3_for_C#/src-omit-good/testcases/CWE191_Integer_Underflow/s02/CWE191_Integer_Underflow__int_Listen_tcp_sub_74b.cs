/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Listen_tcp_sub_74b.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Listen_tcp_sub_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,int> dataDictionary )
    {
        int data = dataDictionary[2];
        /* POTENTIAL FLAW: if data == int.MinValue, this will overflow */
        int result = (int)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif


}
}
