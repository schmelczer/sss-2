/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_console_ReadLine_multiply_54d.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-54d.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_console_ReadLine_multiply_54d
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(uint data )
    {
        CWE191_Integer_Underflow__UInt32_console_ReadLine_multiply_54e.GoodG2BSink(data );
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(uint data )
    {
        CWE191_Integer_Underflow__UInt32_console_ReadLine_multiply_54e.GoodB2GSink(data );
    }
#endif
}
}
