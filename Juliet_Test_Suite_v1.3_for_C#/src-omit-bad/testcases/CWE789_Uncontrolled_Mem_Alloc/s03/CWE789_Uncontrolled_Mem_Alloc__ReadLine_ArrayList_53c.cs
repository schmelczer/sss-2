/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__ReadLine_ArrayList_53c.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-53c.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: ArrayList
 *    BadSink : Create an ArrayList using data as the initial size
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{
class CWE789_Uncontrolled_Mem_Alloc__ReadLine_ArrayList_53c
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(int data )
    {
        CWE789_Uncontrolled_Mem_Alloc__ReadLine_ArrayList_53d.GoodG2BSink(data );
    }
#endif
}
}
