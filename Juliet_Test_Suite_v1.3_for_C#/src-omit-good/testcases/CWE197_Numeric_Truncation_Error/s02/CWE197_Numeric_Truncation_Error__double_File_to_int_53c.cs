/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_File_to_int_53c.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-53c.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: File Read data from file (named c:\data.txt)
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_int
 *    BadSink : Convert data to a int
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__double_File_to_int_53c
{
#if (!OMITBAD)
    public static void BadSink(double data )
    {
        CWE197_Numeric_Truncation_Error__double_File_to_int_53d.BadSink(data );
    }
#endif


}
}
