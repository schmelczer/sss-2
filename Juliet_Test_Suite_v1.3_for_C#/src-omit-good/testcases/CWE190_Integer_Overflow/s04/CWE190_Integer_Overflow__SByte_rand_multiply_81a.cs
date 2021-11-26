/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_rand_multiply_81a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_rand_multiply_81a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        sbyte data;
        /* POTENTIAL FLAW: Use a random value */
        data = (sbyte)(new Random().Next(sbyte.MinValue, sbyte.MaxValue));
        CWE190_Integer_Overflow__SByte_rand_multiply_81_base baseObject = new CWE190_Integer_Overflow__SByte_rand_multiply_81_bad();
        baseObject.Action(data );
    }
#endif //omitbad

}
}
