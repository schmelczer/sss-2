/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_rand_multiply_45.cs
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
class CWE191_Integer_Underflow__UInt32_rand_multiply_45 : AbstractTestCase
{

    private uint dataBad;
    private uint dataGoodG2B;
    private uint dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        uint data = dataBad;
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < uint.MinValue, this will underflow */
            uint result = (uint)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }

    public override void Bad()
    {
        uint data;
        /* POTENTIAL FLAW: Use a random value */
        data = (uint)(new Random().Next(1 << 30)) << 2 | (uint)(new Random().Next(1 << 2));
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
