/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt64_rand_multiply_45.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt64_rand_multiply_45 : AbstractTestCase
{

    private ulong dataBad;
    private ulong dataGoodG2B;
    private ulong dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        ulong data = dataBad;
        if(data > 0) /* ensure we won't have an underflow */
        {
            /* POTENTIAL FLAW: if (data*2) > ulong.MaxValue, this will overflow */
            ulong result = (ulong)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }

    public override void Bad()
    {
        ulong data;
        /* POTENTIAL FLAW: Use a random value */
        data = IO.GetRandomULong();
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
