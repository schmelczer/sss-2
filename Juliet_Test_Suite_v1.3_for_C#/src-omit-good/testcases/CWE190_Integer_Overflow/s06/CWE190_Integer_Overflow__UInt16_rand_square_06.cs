/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt16_rand_square_06.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-06.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt16_rand_square_06 : AbstractTestCase
{

    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value. */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        ushort data;
        if (PRIVATE_CONST_FIVE==5)
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
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: if (data*data) > ushort.MaxValue, this will overflow */
            ushort result = (ushort)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
