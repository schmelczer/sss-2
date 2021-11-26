/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt64_console_readLine_add_22b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: console_readLine Read data from the console using readLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt64_console_readLine_add_22b
{
#if (!OMITBAD)
    public static void BadSink(ulong data )
    {
        if (CWE190_Integer_Overflow__UInt64_console_readLine_add_22a.badPublicStatic)
        {
            /* POTENTIAL FLAW: if data == ulong.MaxValue, this will overflow */
            ulong result = (ulong)(data + 1);
            IO.WriteLine("result: " + result);
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0ul;
        }
    }
#endif


}
}
