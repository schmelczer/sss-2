/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Byte_max_square_09.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-09.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: max Set data to the max value for byte
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Byte_max_square_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        byte data;
        if (IO.STATIC_READONLY_TRUE)
        {
            /* POTENTIAL FLAW: Use the maximum size of the data type */
            data = byte.MaxValue;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (IO.STATIC_READONLY_TRUE)
        {
            /* POTENTIAL FLAW: if (data*data) > byte.MaxValue, this will overflow */
            byte result = (byte)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
