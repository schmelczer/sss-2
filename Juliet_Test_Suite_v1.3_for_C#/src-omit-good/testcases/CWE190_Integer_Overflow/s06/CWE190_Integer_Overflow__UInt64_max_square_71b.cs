/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt64_max_square_71b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-71b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for ulong
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;

using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt64_max_square_71b
{
#if (!OMITBAD)
    public static void BadSink(Object dataObject )
    {
        ulong data = (ulong)dataObject;
        /* POTENTIAL FLAW: if (data*data) > ulong.MaxValue, this will overflow */
        ulong result = (ulong)(data * data);
        IO.WriteLine("result: " + result);
    }
#endif


}
}
