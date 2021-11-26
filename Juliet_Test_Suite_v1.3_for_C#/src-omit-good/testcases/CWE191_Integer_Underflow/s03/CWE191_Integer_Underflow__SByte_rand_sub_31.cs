/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__SByte_rand_sub_31.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-31.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__SByte_rand_sub_31 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        sbyte dataCopy;
        {
            sbyte data;
            /* POTENTIAL FLAW: Use a random value */
            data = (sbyte)(new Random().Next(sbyte.MinValue, sbyte.MaxValue));
            dataCopy = data;
        }
        {
            sbyte data = dataCopy;
            /* POTENTIAL FLAW: if data == sbyte.MinValue, this will overflow */
            sbyte result = (sbyte)(data - 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
