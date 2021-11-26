/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__int_Random_to_short_54b.cs
Label Definition File: CWE197_Numeric_Truncation_Error__int.label.xml
Template File: sources-sink-54b.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_short
 *    BadSink : Convert data to a short
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__int_Random_to_short_54b
{
#if (!OMITBAD)
    public static void BadSink(int data )
    {
        CWE197_Numeric_Truncation_Error__int_Random_to_short_54c.BadSink(data );
    }
#endif


}
}