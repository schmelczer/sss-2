/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__NetClient_HashSet_21.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-21.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: HashSet
 *    BadSink : Create a HashSet using data as the initial size
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
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

class CWE789_Uncontrolled_Mem_Alloc__NetClient_HashSet_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the source function */
    private bool badPrivate = false;

    /* The variables below are used to drive control flow in the source functions. */
    private bool goodG2B1_private = false;
    private bool GoodG2B2_private = false;
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B1();
        GoodG2B2();
    }

    /* goodG2B1() - use goodsource and badsink by setting the variable to false instead of true */
    private void GoodG2B1()
    {
        int data;
        goodG2B1_private = false;
        data = GoodG2B1_source();
        /* POTENTIAL FLAW: Create a HashSet using data as the initial size.  data may be very large, creating memory issues */
        HashSet<int> intHashSet = new HashSet<int>(data);
    }

    private int GoodG2B1_source()
    {
        int data = 0;
        if (goodG2B1_private)
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
        return data;
    }

    /* GoodG2B2() - use goodsource and badsink by reversing the blocks in the if in the sink function */
    private void GoodG2B2()
    {
        int data;
        GoodG2B2_private = true;
        data = GoodG2B2_source();
        /* POTENTIAL FLAW: Create a HashSet using data as the initial size.  data may be very large, creating memory issues */
        HashSet<int> intHashSet = new HashSet<int>(data);
    }

    private int GoodG2B2_source()
    {
        int data = 0;
        if (GoodG2B2_private)
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
        return data;
    }
#endif //omitgood
}
}