/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__MaxValue_HashSet_61b.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: MaxValue Set data to a hardcoded value of Integer.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: HashSet
 *    BadSink : Create a HashSet using data as the initial size
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__MaxValue_HashSet_61b
{
#if (!OMITBAD)
    public static int BadSource()
    {
        int data;
        /* FLAW: Set data to Integer.MaxValue */
        data = int.MaxValue;
        return data;
    }
#endif


}
}
