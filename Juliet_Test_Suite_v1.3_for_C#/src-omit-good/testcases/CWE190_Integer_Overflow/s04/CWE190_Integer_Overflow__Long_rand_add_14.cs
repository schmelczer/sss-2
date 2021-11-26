/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Long_rand_add_14.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-14.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Long_rand_add_14 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        if (IO.staticFive==5)
        {
            /* POTENTIAL FLAW: Use a random value */
            data = IO.GetRandomLong();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0L;
        }
        if (IO.staticFive==5)
        {
            /* POTENTIAL FLAW: if data == long.MaxValue, this will overflow */
            long result = (long)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
