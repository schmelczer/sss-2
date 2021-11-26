/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Database_for_loop_73b.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Database Read count from a database
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: for_loop
 *    GoodSink: Validate count before using it as the loop variant in a for loop
 *    BadSink : Use count as the loop variant in a for loop
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Database_for_loop_73b
{
#if (!OMITBAD)
    public static void BadSink(LinkedList<int> countLinkedList )
    {
        int count = countLinkedList.Last.Value;
        int i = 0;
        /* POTENTIAL FLAW: For loop using count as the loop variant and no validation */
        for (i = 0; i < count; i++)
        {
            IO.WriteLine("Hello");
        }
    }
#endif


}
}
