/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_rand_multiply_10.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-10.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an underflow before multiplying data by 2
*    BadSink : If data is negative, multiply by 2, which can cause an underflow
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_rand_multiply_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        if (IO.staticTrue)
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
        if (IO.staticTrue)
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < uint.MinValue, this will underflow */
                uint result = (uint)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad

}
}
