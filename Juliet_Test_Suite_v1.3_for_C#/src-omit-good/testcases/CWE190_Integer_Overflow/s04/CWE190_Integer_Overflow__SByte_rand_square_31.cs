/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_rand_square_31.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-31.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_rand_square_31 : AbstractTestCase
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
            /* POTENTIAL FLAW: if (data*data) > sbyte.MaxValue, this will overflow */
            sbyte result = (sbyte)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
