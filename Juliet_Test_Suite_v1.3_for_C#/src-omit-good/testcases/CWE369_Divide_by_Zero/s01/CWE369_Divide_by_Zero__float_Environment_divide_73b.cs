/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_Environment_divide_73b.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_Environment_divide_73b
{
#if (!OMITBAD)
    public static void BadSink(LinkedList<float> dataLinkedList )
    {
        float data = dataLinkedList.Last.Value;
        /* POTENTIAL FLAW: Possibly divide by zero */
        int result = (int)(100.0 / data);
        IO.WriteLine(result);
    }
#endif


}
}
