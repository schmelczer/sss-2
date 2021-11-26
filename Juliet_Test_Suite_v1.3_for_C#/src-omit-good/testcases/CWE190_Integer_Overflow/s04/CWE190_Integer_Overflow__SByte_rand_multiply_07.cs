/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_rand_multiply_07.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-07.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an overflow before multiplying data by 2
*    BadSink : If data is positive, multiply by 2, which can cause an overflow
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_rand_multiply_07 : AbstractTestCase
{

    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value. */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        sbyte data;
        if (privateFive==5)
        {
            /* POTENTIAL FLAW: Use a random value */
            data = (sbyte)(new Random().Next(sbyte.MinValue, sbyte.MaxValue));
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (privateFive==5)
        {
            if(data > 0) /* ensure we won't have an underflow */
            {
                /* POTENTIAL FLAW: if (data*2) > sbyte.MaxValue, this will overflow */
                sbyte result = (sbyte)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad

}
}
