/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__NetClient_HashSet_03.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-03.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: HashSet Create a HashSet using data as the initial size
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Collections.Generic;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__NetClient_HashSet_03 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing 5==5 to 5!=5 */
    private void GoodG2B1()
    {
        int data;
        if (5 != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        else
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        /* POTENTIAL FLAW: Create a HashSet using data as the initial size.  data may be very large, creating memory issues */
        HashSet<int> intHashSet = new HashSet<int>(data);
    }

    /* GoodG2B2() - use goodsource and badsink by reversing statements in if */
    private void GoodG2B2()
    {
        int data;
        if (5 == 5)
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        /* POTENTIAL FLAW: Create a HashSet using data as the initial size.  data may be very large, creating memory issues */
        HashSet<int> intHashSet = new HashSet<int>(data);
    }

    public override void Good()
    {
        GoodG2B1();
        GoodG2B2();
    }
#endif //omitgood
}
}
