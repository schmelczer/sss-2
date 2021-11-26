/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt32_rand_add_17.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt32_rand_add_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        /* POTENTIAL FLAW: Use a random value */
        data = (uint)(new Random().Next(1 << 30)) << 2 | (uint)(new Random().Next(1 << 2));
        for (int j = 0; j < 1; j++)
        {
            /* POTENTIAL FLAW: if data == uint.MaxValue, this will overflow */
            uint result = (uint)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
