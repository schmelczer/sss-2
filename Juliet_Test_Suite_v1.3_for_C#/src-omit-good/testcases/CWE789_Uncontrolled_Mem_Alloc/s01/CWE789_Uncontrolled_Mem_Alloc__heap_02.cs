/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__heap_02.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc__heap.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* Sinks:
*    GoodSink: check for memory consumption
*    BadSink : no check for memory consumption
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Collections;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{
class CWE789_Uncontrolled_Mem_Alloc__heap_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
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
