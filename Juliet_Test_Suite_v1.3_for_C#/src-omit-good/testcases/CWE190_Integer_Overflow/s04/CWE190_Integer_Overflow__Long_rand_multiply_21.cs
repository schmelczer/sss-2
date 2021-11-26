/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Long_rand_multiply_21.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Long_rand_multiply_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        /* POTENTIAL FLAW: Use a random value */
        data = IO.GetRandomLong();
        badPrivate = true;
        BadSink(data );
    }

    private void BadSink(long data )
    {
        if (badPrivate)
        {
            if(data > 0) /* ensure we won't have an underflow */
            {
                /* POTENTIAL FLAW: if (data*2) > long.MaxValue, this will overflow */
                long result = (long)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;

}
}
