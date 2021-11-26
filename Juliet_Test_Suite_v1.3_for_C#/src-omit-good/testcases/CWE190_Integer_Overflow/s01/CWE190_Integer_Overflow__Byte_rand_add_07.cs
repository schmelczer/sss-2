/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Byte_rand_add_07.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-07.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Byte_rand_add_07 : AbstractTestCase
{

    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value. */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        byte data;
        if (privateFive==5)
        {
            /* POTENTIAL FLAW: Use a random value */
            data = (byte)(new Random().Next(byte.MinValue, byte.MaxValue));
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (privateFive==5)
        {
            /* POTENTIAL FLAW: if data == byte.MaxValue, this will overflow */
            byte result = (byte)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
