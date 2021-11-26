/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__heap_08.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc__heap.label.xml
Template File: point-flaw-08.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* Sinks:
*    GoodSink: check for memory consumption
*    BadSink : no check for memory consumption
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Collections;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{
class CWE789_Uncontrolled_Mem_Alloc__heap_08 : AbstractTestCase
{
    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false.
     */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        if (PrivateReturnsTrue())
        {
            ArrayList byteArrayList = new ArrayList();
            while(true)
            {
                /* FLAW: continued consumption of memory in 10MB XXXXXs with no verification of available memory */
                byte[] byteArray = new byte[10485760];
                byteArrayList.Add(byteArray);
            }
        }
    }
#endif //omitbad

}
}
