/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__MaxValue_ArrayList_15.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-15.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* BadSource: MaxValue Set data to a hardcoded value of Integer.MaxValue
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: ArrayList Create an ArrayList using data as the initial size
* Flow Variant: 15 Control flow: switch(6)
*
* */

using TestCaseSupport;
using System;

using System.Collections;

using System.Web;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__MaxValue_ArrayList_15 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        int data = 0;
        switch (6)
        {
        case 6:
            /* FLAW: Set data to Integer.MaxValue */
            data = int.MaxValue;
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
            break;
        }
        /* POTENTIAL FLAW: Create an ArrayList using data as the initial size.  data may be very large, creating memory issues */
        ArrayList intArrayList = new ArrayList(data);
    }
#endif //omitbad

}
}
