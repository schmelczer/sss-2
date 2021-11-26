/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_console_ReadLine_multiply_53c.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-53c.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_console_ReadLine_multiply_53c
{
#if (!OMITBAD)
    public static void BadSink(uint data )
    {
        CWE191_Integer_Underflow__UInt32_console_ReadLine_multiply_53d.BadSink(data );
    }
#endif


}
}
