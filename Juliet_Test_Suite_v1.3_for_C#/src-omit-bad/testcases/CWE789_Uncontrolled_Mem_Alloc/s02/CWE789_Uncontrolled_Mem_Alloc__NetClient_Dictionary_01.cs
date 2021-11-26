/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__NetClient_Dictionary_01.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-01.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: Dictionary Create a Dictionary using data as the initial size
* Flow Variant: 01 Baseline
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

class CWE789_Uncontrolled_Mem_Alloc__NetClient_Dictionary_01 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - uses goodsource and badsink */
    private void GoodG2B()
    {
        int data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        /* POTENTIAL FLAW: Create a Dictionary using data as the initial size.  data may be very large, creating memory issues */
        Dictionary<int, int> dict = new Dictionary<int, int>(data);
    }
#endif //omitgood
}
}
