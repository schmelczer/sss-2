/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__SByte_min_sub_61b.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for sbyte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__SByte_min_sub_61b
{
#if (!OMITBAD)
    public static sbyte BadSource()
    {
        sbyte data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = sbyte.MinValue;
        return data;
    }
#endif


}
}
