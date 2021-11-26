/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_zero_divide_73a.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: zero Set data to a hardcoded value of zero
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_zero_divide_73a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        data = 0.0f; /* POTENTIAL FLAW: data is set to zero */
        LinkedList<float> dataLinkedList = new LinkedList<float>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE369_Divide_by_Zero__float_zero_divide_73b.BadSink(dataLinkedList  );
    }
#endif //omitbad

}
}
