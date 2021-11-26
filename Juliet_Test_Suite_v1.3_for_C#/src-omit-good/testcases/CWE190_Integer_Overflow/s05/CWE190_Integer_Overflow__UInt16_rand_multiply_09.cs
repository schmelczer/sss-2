/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt16_rand_multiply_09.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-09.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an overflow before multiplying data by 2
*    BadSink : If data is positive, multiply by 2, which can cause an overflow
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt16_rand_multiply_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ushort data;
        if (IO.STATIC_READONLY_TRUE)
        {
            /* POTENTIAL FLAW: Use a random value */
            data = (ushort)(new Random().Next(ushort.MinValue, ushort.MaxValue));
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (IO.STATIC_READONLY_TRUE)
        {
            if(data > 0) /* ensure we won't have an underflow */
            {
                /* POTENTIAL FLAW: if (data*2) > ushort.MaxValue, this will overflow */
                ushort result = (ushort)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad

}
}
