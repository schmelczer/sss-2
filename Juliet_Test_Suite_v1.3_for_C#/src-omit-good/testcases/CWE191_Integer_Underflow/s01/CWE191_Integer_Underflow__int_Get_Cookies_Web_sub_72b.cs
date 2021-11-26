/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Get_Cookies_Web_sub_72b.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-72b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Get_Cookies_Web_sub_72b
{
#if (!OMITBAD)
    public static void BadSink(Hashtable dataHashtable , HttpRequest req, HttpResponse resp)
    {
        int data = (int) dataHashtable[2];
        /* POTENTIAL FLAW: if data == int.MinValue, this will overflow */
        int result = (int)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif


}
}
