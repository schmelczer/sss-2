/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__Connect_tcp_Dictionary_10.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-10.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* BadSource: Connect_tcp Read data using an outbound tcp connection
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: Dictionary Create a Dictionary using data as the initial size
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Collections.Generic;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__Connect_tcp_Dictionary_10 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing IO.staticTrue to IO.staticFalse */
    private void GoodG2B1()
    {
        int data;
        if (IO.staticFalse)
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
        /* POTENTIAL FLAW: Create a Dictionary using data as the initial size.  data may be very large, creating memory issues */
        Dictionary<int, int> dict = new Dictionary<int, int>(data);
    }

    /* GoodG2B2() - use goodsource and badsink by reversing statements in if */
    private void GoodG2B2()
    {
        int data;
        if (IO.staticTrue)
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
        /* POTENTIAL FLAW: Create a Dictionary using data as the initial size.  data may be very large, creating memory issues */
        Dictionary<int, int> dict = new Dictionary<int, int>(data);
    }

    public override void Good()
    {
        GoodG2B1();
        GoodG2B2();
    }
#endif //omitgood
}
}
