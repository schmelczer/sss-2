/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__short_console_ReadLine_66b.cs
Label Definition File: CWE197_Numeric_Truncation_Error__short.label.xml
Template File: sources-sink-66b.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__short_console_ReadLine_66b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(short[] dataArray )
    {
        short data = dataArray[2];
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }
#endif
}
}