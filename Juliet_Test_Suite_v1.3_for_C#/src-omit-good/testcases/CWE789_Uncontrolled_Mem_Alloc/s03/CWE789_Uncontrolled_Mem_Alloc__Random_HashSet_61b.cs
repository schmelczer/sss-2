/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__Random_HashSet_61b.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: Random Set data to a random value
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

class CWE789_Uncontrolled_Mem_Alloc__Random_HashSet_61b
{
#if (!OMITBAD)
    public static int BadSource()
    {
        int data;
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        return data;
    }
#endif


}
}
