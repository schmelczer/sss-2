/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_max_add_42.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for sbyte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_max_add_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static sbyte BadSource()
    {
        sbyte data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = sbyte.MaxValue;
        return data;
    }

    public override void Bad()
    {
        sbyte data = BadSource();
        /* POTENTIAL FLAW: if data == sbyte.MaxValue, this will overflow */
        sbyte result = (sbyte)(data + 1);
        IO.WriteLine("result: " + result);
    }
#endif //omitbad

}
}
