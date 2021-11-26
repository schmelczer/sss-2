/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Byte_max_square_04.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-04.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: max Set data to the max value for byte
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Byte_max_square_04 : AbstractTestCase
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        byte data;
        if (PRIVATE_CONST_TRUE)
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
        if (PRIVATE_CONST_TRUE)
        {
            /* POTENTIAL FLAW: if (data*data) > byte.MaxValue, this will overflow */
            byte result = (byte)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
