/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__File_Dictionary_61a.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: File Read data from file (named c:\data.txt)
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: Dictionary
 *    BadSink : Create a Dictionary using data as the initial size
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Collections.Generic;

using System.Web;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{
class CWE789_Uncontrolled_Mem_Alloc__File_Dictionary_61a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        int data = CWE789_Uncontrolled_Mem_Alloc__File_Dictionary_61b.GoodG2BSource();
        /* POTENTIAL FLAW: Create a Dictionary using data as the initial size.  data may be very large, creating memory issues */
        Dictionary<int, int> dict = new Dictionary<int, int>(data);
    }
#endif //omitgood
}
}
