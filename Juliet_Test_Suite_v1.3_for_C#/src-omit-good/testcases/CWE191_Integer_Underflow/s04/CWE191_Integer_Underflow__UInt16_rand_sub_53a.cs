/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_rand_sub_53a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-53a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_rand_sub_53a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ushort data;
        /* POTENTIAL FLAW: Use a random value */
        data = (ushort)(new Random().Next(ushort.MinValue, ushort.MaxValue));
        CWE191_Integer_Underflow__UInt16_rand_sub_53b.BadSink(data );
    }
#endif //omitbad

}
}
