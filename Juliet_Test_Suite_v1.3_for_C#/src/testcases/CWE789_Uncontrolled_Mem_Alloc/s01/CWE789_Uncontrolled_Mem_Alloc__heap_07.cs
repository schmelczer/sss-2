/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__heap_07.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc__heap.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* Sinks:
*    GoodSink: check for memory consumption
*    BadSink : no check for memory consumption
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Collections;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{
class CWE789_Uncontrolled_Mem_Alloc__heap_07 : AbstractTestCase
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (privateFive == 5)
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
#if (!OMITGOOD)
    /* Good1() changes privateFive==5 to privateFive!=5 */
    private void Good1()
    {
        if (privateFive != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            ArrayList byteArrayList = new ArrayList();
            while (true)
            {
                try
                {
                    /* consume memory in 10MB chunks */
                    byte[] byteArray = new byte[10485760];
                    byteArrayList.Add(byteArray);
                }
                /* FIX: check memory consumption */
                catch (OutOfMemoryException e)
                {
                    IO.WriteLine("Not enough memory to go again");
                    break;
                }
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (privateFive == 5)
        {
            ArrayList byteArrayList = new ArrayList();
            while (true)
            {
                try
                {
                    /* consume memory in 10MB chunks */
                    byte[] byteArray = new byte[10485760];
                    byteArrayList.Add(byteArray);
                }
                /* FIX: check memory consumption */
                catch (OutOfMemoryException e)
                {
                    IO.WriteLine("Not enough memory to go again");
                    break;
                }
            }
        }
    }

    public override void Good()
    {
        Good1();
        Good2();
    }
#endif //omitgood
}
}
