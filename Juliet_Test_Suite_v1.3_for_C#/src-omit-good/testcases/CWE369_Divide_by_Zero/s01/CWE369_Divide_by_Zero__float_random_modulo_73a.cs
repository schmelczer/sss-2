/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_random_modulo_73a.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: random Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive)
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_random_modulo_73a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        /* POTENTIAL FLAW: Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive) */
        Random rand = new Random();
        data = (float)rand.NextDouble();
        LinkedList<float> dataLinkedList = new LinkedList<float>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE369_Divide_by_Zero__float_random_modulo_73b.BadSink(dataLinkedList  );
    }
#endif //omitbad

}
}
