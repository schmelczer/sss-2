/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Long_rand_sub_13.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-13.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: sub
*    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
*    BadSink : Subtract 1 from data, which can cause an Underflow
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Long_rand_sub_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        if (IO.STATIC_READONLY_FIVE==5)
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
        if (IO.STATIC_READONLY_FIVE==5)
        {
            /* POTENTIAL FLAW: if data == long.MinValue, this will overflow */
            long result = (long)(data - 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
