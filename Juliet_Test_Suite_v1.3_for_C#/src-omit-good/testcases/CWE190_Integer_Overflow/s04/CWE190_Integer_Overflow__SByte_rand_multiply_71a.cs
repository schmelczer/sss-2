/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_rand_multiply_71a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_rand_multiply_71a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        sbyte data;
        /* POTENTIAL FLAW: Use a random value */
        data = (sbyte)(new Random().Next(sbyte.MinValue, sbyte.MaxValue));
        CWE190_Integer_Overflow__SByte_rand_multiply_71b.BadSink((Object)data  );
    }
#endif //omitbad

}
}
