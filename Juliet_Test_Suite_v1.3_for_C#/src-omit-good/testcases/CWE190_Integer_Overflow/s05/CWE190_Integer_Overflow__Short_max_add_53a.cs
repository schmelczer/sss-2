/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Short_max_add_53a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-53a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for short
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Short_max_add_53a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = short.MaxValue;
        CWE190_Integer_Overflow__Short_max_add_53b.BadSink(data );
    }
#endif //omitbad

}
}
