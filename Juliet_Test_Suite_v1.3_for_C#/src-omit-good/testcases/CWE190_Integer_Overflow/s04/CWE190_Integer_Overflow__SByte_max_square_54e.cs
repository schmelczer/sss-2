/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_max_square_54e.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-54e.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for sbyte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_max_square_54e
{
#if (!OMITBAD)
    public static void BadSink(sbyte data )
    {
        /* POTENTIAL FLAW: if (data*data) > sbyte.MaxValue, this will overflow */
        sbyte result = (sbyte)(data * data);
        IO.WriteLine("result: " + result);
    }
#endif


}
}
