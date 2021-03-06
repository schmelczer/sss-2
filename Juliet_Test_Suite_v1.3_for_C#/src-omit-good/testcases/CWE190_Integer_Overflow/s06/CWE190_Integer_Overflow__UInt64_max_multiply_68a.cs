/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt64_max_multiply_68a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for ulong
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt64_max_multiply_68a : AbstractTestCase
{

    public static ulong data;
#if (!OMITBAD)
    public override void Bad()
    {
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = ulong.MaxValue;
        CWE190_Integer_Overflow__UInt64_max_multiply_68b.BadSink();
    }
#endif //omitbad

}
}
