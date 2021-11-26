/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Short_max_add_13.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-13.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: max Set data to the max value for short
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Short_max_add_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        if (IO.STATIC_READONLY_FIVE==5)
        {
            /* POTENTIAL FLAW: Use the maximum size of the data type */
            data = short.MaxValue;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (IO.STATIC_READONLY_FIVE==5)
        {
            /* POTENTIAL FLAW: if data == short.MaxValue, this will overflow */
            short result = (short)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
