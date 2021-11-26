/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_rand_multiply_67a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_rand_multiply_67a : AbstractTestCase
{

    public class Container
    {
        public sbyte containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        sbyte data;
        /* POTENTIAL FLAW: Use a random value */
        data = (sbyte)(new Random().Next(sbyte.MinValue, sbyte.MaxValue));
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE190_Integer_Overflow__SByte_rand_multiply_67b.BadSink(dataContainer  );
    }
#endif //omitbad

}
}
