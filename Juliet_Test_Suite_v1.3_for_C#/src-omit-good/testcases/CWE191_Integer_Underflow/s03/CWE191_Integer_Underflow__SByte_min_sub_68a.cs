/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__SByte_min_sub_68a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for sbyte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__SByte_min_sub_68a : AbstractTestCase
{

    public static sbyte data;
#if (!OMITBAD)
    public override void Bad()
    {
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = sbyte.MinValue;
        CWE191_Integer_Underflow__SByte_min_sub_68b.BadSink();
    }
#endif //omitbad

}
}
