/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__heap_10.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc__heap.label.xml
Template File: point-flaw-10.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* Sinks:
*    GoodSink: check for memory consumption
*    BadSink : no check for memory consumption
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Collections;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{
class CWE789_Uncontrolled_Mem_Alloc__heap_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.staticTrue)
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
