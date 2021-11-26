/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt32_max_square_15.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: max Set data to the max value for uint
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt32_max_square_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        switch (6)
        {
        case 6:
            /* POTENTIAL FLAW: Use the maximum size of the data type */
            data = uint.MaxValue;
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0u;
            break;
        }
        switch (7)
        {
        case 7:
            /* POTENTIAL FLAW: if (data*data) > uint.MaxValue, this will overflow */
            uint result = (uint)(data * data);
            IO.WriteLine("result: " + result);
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
