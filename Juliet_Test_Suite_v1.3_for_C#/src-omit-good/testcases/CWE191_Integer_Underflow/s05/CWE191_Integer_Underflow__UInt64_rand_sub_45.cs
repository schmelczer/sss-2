/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt64_rand_sub_45.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt64_rand_sub_45 : AbstractTestCase
{

    private ulong dataBad;
    private ulong dataGoodG2B;
    private ulong dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        ulong data = dataBad;
        /* POTENTIAL FLAW: if data == ulong.MinValue, this will overflow */
        ulong result = (ulong)(data - 1);
        IO.WriteLine("result: " + result);
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
