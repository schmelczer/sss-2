/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__MaxValue_ArrayList_04.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-04.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* BadSource: MaxValue Set data to a hardcoded value of Integer.MaxValue
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: ArrayList Create an ArrayList using data as the initial size
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Collections;

using System.Web;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__MaxValue_ArrayList_04 : AbstractTestCase
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        int data;
        if (PRIVATE_CONST_TRUE)
        {
            /* FLAW: Set data to Integer.MaxValue */
            data = int.MaxValue;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        /* POTENTIAL FLAW: Create an ArrayList using data as the initial size.  data may be very large, creating memory issues */
        ArrayList intArrayList = new ArrayList(data);
    }
#endif //omitbad

}
}
