/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt64_console_ReadLine_multiply_67b.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt64_console_ReadLine_multiply_67b
{
#if (!OMITBAD)
    public static void BadSink(CWE191_Integer_Underflow__UInt64_console_ReadLine_multiply_67a.Container dataContainer )
    {
        ulong data = dataContainer.containerOne;
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < ulong.MinValue, this will underflow */
            ulong result = (ulong)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }
#endif


}
}
