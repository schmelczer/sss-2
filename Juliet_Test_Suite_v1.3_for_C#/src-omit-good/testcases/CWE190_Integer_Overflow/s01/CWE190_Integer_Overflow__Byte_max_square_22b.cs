/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Byte_max_square_22b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for byte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Byte_max_square_22b
{
#if (!OMITBAD)
    public static void BadSink(byte data )
    {
        if (CWE190_Integer_Overflow__Byte_max_square_22a.badPublicStatic)
        {
            /* POTENTIAL FLAW: if (data*data) > byte.MaxValue, this will overflow */
            byte result = (byte)(data * data);
            IO.WriteLine("result: " + result);
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
    }
#endif


}
}
