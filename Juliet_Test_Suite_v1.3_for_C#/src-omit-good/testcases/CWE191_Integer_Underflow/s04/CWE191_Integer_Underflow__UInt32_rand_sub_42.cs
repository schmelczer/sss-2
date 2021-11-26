/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_rand_sub_42.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_rand_sub_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static uint BadSource()
    {
        uint data;
        /* POTENTIAL FLAW: Use a random value */
        data = (uint)(new Random().Next(1 << 30)) << 2 | (uint)(new Random().Next(1 << 2));
        return data;
    }

    public override void Bad()
    {
        uint data = BadSource();
        /* POTENTIAL FLAW: if data == uint.MinValue, this will overflow */
        uint result = (uint)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif //omitbad

}
}
