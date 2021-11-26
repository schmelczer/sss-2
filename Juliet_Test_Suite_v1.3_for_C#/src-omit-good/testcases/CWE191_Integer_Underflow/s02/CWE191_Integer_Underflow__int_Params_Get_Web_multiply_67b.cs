/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Params_Get_Web_multiply_67b.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Params_Get_Web_multiply_67b
{
#if (!OMITBAD)
    public static void BadSink(CWE191_Integer_Underflow__int_Params_Get_Web_multiply_67a.Container dataContainer , HttpRequest req, HttpResponse resp)
    {
        int data = dataContainer.containerOne;
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < int.MinValue, this will underflow */
            int result = (int)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }
#endif


}
}
