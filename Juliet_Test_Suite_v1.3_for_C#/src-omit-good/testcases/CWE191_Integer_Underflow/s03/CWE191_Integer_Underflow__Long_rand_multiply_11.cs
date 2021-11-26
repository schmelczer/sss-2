/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Long_rand_multiply_11.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-11.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an underflow before multiplying data by 2
*    BadSink : If data is negative, multiply by 2, which can cause an underflow
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Long_rand_multiply_11 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        if (IO.StaticReturnsTrue())
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
        if(IO.StaticReturnsTrue())
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < long.MinValue, this will underflow */
                long result = (long)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad

}
}
