/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Short_rand_multiply_45.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Short_rand_multiply_45 : AbstractTestCase
{

    private short dataBad;
    private short dataGoodG2B;
    private short dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        short data = dataBad;
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < short.MinValue, this will underflow */
            short result = (short)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }

    public override void Bad()
    {
        short data;
        /* POTENTIAL FLAW: Use a random value */
        data = (short)(new Random().Next(short.MinValue, short.MaxValue));
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
