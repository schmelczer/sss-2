/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Long_rand_sub_17.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: sub
*    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
*    BadSink : Subtract 1 from data, which can cause an Underflow
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Long_rand_sub_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        /* POTENTIAL FLAW: Use a random value */
        data = IO.GetRandomLong();
        for (int j = 0; j < 1; j++)
        {
            /* POTENTIAL FLAW: if data == long.MinValue, this will overflow */
            long result = (long)(data - 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
