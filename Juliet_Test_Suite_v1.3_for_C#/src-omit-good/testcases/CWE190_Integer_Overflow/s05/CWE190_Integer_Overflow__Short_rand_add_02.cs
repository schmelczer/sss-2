/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Short_rand_add_02.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Short_rand_add_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        if (true)
        {
            /* POTENTIAL FLAW: Use a random value */
            data = (short)(new Random().Next(short.MinValue, short.MaxValue));
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (true)
        {
            /* POTENTIAL FLAW: if data == short.MaxValue, this will overflow */
            short result = (short)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
