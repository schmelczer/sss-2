/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt16_rand_square_72b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-72b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt16_rand_square_72b
{
#if (!OMITBAD)
    public static void BadSink(Hashtable dataHashtable )
    {
        ushort data = (ushort) dataHashtable[2];
        /* POTENTIAL FLAW: if (data*data) > ushort.MaxValue, this will overflow */
        ushort result = (ushort)(data * data);
        IO.WriteLine("result: " + result);
    }
#endif


}
}
