/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt16_rand_add_73b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt16_rand_add_73b
{
#if (!OMITBAD)
    public static void BadSink(LinkedList<ushort> dataLinkedList )
    {
        ushort data = dataLinkedList.Last.Value;
        /* POTENTIAL FLAW: if data == ushort.MaxValue, this will overflow */
        ushort result = (ushort)(data + 1);
        IO.WriteLine("result: " + result);
    }
#endif


}
}
