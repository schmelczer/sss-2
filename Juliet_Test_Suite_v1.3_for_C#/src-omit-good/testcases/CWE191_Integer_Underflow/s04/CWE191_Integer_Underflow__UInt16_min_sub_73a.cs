/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_min_sub_73a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for ushort
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_min_sub_73a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ushort data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = ushort.MinValue;
        LinkedList<ushort> dataLinkedList = new LinkedList<ushort>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE191_Integer_Underflow__UInt16_min_sub_73b.BadSink(dataLinkedList  );
    }
#endif //omitbad

}
}
