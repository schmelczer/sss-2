/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_File_divide_73b.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: File Read data from file (named c:\data.txt)
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
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
class CWE369_Divide_by_Zero__int_File_divide_73b
{


#if (!OMITGOOD)
    /* goodG2B() - use GoodSource and BadSink */
    public static void GoodG2BSink(LinkedList<int> dataLinkedList )
    {
        int data = dataLinkedList.Last.Value;
        /* POTENTIAL FLAW: Zero denominator will cause an issue.  An integer division will
        result in an exception. */
        IO.WriteLine("bad: 100/" + data + " = " + (100 / data) + "\n");
    }

    /* goodB2G() - use BadSource and GoodSink */
    public static void GoodB2GSink(LinkedList<int> dataLinkedList )
    {
        int data = dataLinkedList.Last.Value;
        /* FIX: test for a zero denominator */
        if (data != 0)
        {
            IO.WriteLine("100/" + data + " = " + (100 / data) + "\n");
        }
        else
        {
            IO.WriteLine("This would result in a divide by zero");
        }
    }
#endif
}
}