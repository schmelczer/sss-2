/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Long_max_square_14.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-14.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: max Set data to the max value for long
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Long_max_square_14 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        if (IO.staticFive==5)
        {
            /* POTENTIAL FLAW: Use the maximum size of the data type */
            data = long.MaxValue;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0L;
        }
        if (IO.staticFive==5)
        {
            /* POTENTIAL FLAW: if (data*data) > long.MaxValue, this will overflow */
            long result = (long)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
