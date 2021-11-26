/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__SByte_console_ReadLine_sub_66b.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-66b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__SByte_console_ReadLine_sub_66b
{
#if (!OMITBAD)
    public static void BadSink(sbyte[] dataArray )
    {
        sbyte data = dataArray[2];
        /* POTENTIAL FLAW: if data == sbyte.MinValue, this will overflow */
        sbyte result = (sbyte)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif


}
}