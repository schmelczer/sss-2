/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt32_rand_square_03.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-03.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt32_rand_square_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        if (5==5)
        {
            /* POTENTIAL FLAW: Use a random value */
            data = (uint)(new Random().Next(1 << 30)) << 2 | (uint)(new Random().Next(1 << 2));
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0u;
        }
        if (5==5)
        {
            /* POTENTIAL FLAW: if (data*data) > uint.MaxValue, this will overflow */
            uint result = (uint)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}