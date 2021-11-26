/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__Database_HashSet_16.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-16.tmpl.cs
*/
/*
* @description
* CWE: 789 Uncontrolled Memory Allocation
* BadSource: Database Read data from a database
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: HashSet Create a HashSet using data as the initial size
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Collections.Generic;

using System.Web;

using System.Data.SqlClient;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__Database_HashSet_16 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        int data;
        while (true)
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
            break;
        }
        /* POTENTIAL FLAW: Create a HashSet using data as the initial size.  data may be very large, creating memory issues */
        HashSet<int> intHashSet = new HashSet<int>(data);
    }

    public override void Good()
    {
        GoodG2B();
    }
#endif //omitgood
}
}
