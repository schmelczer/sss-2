/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_rand_multiply_45.cs
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
class CWE191_Integer_Underflow__UInt16_rand_multiply_45 : AbstractTestCase
{

    private ushort dataBad;
    private ushort dataGoodG2B;
    private ushort dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        ushort data = dataBad;
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < ushort.MinValue, this will underflow */
            ushort result = (ushort)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }

    public override void Bad()
    {
        ushort data;
        /* POTENTIAL FLAW: Use a random value */
        data = (ushort)(new Random().Next(ushort.MinValue, ushort.MaxValue));
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
