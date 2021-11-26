/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__MaxValue_ArrayList_17.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-17.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* BadSource: MaxValue Set data to a hardcoded value of Integer.MaxValue
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: ArrayList Create an ArrayList using data as the initial size
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Collections;

using System.Web;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__MaxValue_ArrayList_17 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        int data;
        /* FLAW: Set data to Integer.MaxValue */
        data = int.MaxValue;
        for (int i = 0; i < 1; i++)
        {
            /* POTENTIAL FLAW: Create an ArrayList using data as the initial size.  data may be very large, creating memory issues */
            ArrayList intArrayList = new ArrayList(data);
        }
    }
#endif //omitbad

}
}
