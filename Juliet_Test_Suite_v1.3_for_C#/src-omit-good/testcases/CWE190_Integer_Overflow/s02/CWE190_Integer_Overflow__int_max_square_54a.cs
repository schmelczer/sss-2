/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_max_square_54a.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the maximum value for int
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_max_square_54a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        /* POTENTIAL FLAW: Use the maximum value for this type */
        data = int.MaxValue;
        CWE190_Integer_Overflow__int_max_square_54b.BadSink(data );
    }
#endif //omitbad

}
}
