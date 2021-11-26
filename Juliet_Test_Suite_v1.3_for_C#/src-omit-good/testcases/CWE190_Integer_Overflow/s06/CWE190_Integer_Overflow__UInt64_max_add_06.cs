/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt64_max_add_06.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-06.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: max Set data to the max value for ulong
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt64_max_add_06 : AbstractTestCase
{

    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value. */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        ulong data;
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: Use the maximum size of the data type */
            data = ulong.MaxValue;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0ul;
        }
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: if data == ulong.MaxValue, this will overflow */
            ulong result = (ulong)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
