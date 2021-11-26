/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Short_max_square_51b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-51b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for short
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Short_max_square_51b
{
#if (!OMITBAD)
    public static void BadSink(short data )
    {
        /* POTENTIAL FLAW: if (data*data) > short.MaxValue, this will overflow */
        short result = (short)(data * data);
        IO.WriteLine("result: " + result);
    }
#endif


}
}
