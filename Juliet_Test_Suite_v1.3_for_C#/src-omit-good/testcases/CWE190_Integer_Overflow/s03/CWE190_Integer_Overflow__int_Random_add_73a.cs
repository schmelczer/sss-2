/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Random_add_73a.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Random_add_73a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        LinkedList<int> dataLinkedList = new LinkedList<int>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE190_Integer_Overflow__int_Random_add_73b.BadSink(dataLinkedList  );
    }
#endif //omitbad

}
}
