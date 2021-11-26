/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Byte_max_square_16.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: max Set data to the max value for byte
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Byte_max_square_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        byte data;
        while (true)
        {
            /* POTENTIAL FLAW: Use the maximum size of the data type */
            data = byte.MaxValue;
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: if (data*data) > byte.MaxValue, this will overflow */
            byte result = (byte)(data * data);
            IO.WriteLine("result: " + result);
            break;
        }
    }
#endif //omitbad

}
}
