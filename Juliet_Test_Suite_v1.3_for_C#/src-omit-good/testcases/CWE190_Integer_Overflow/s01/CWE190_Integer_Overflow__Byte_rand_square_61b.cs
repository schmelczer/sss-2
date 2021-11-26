/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Byte_rand_square_61b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Byte_rand_square_61b
{
#if (!OMITBAD)
    public static byte BadSource()
    {
        byte data;
        /* POTENTIAL FLAW: Use a random value */
        data = (byte)(new Random().Next(byte.MinValue, byte.MaxValue));
        return data;
    }
#endif


}
}