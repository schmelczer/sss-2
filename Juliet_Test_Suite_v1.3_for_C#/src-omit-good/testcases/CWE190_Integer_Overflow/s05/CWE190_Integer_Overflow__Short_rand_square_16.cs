/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Short_rand_square_16.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Short_rand_square_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        while (true)
        {
            /* POTENTIAL FLAW: Use a random value */
            data = (short)(new Random().Next(short.MinValue, short.MaxValue));
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: if (data*data) > short.MaxValue, this will overflow */
            short result = (short)(data * data);
            IO.WriteLine("result: " + result);
            break;
        }
    }
#endif //omitbad

}
}
