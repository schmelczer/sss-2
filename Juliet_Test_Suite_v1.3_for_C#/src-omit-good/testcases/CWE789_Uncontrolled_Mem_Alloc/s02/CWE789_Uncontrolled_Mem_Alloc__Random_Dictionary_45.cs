/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__Random_Dictionary_45.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: Dictionary
 *    BadSink : Create a Dictionary using data as the initial size
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Collections.Generic;

using System.Web;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__Random_Dictionary_45 : AbstractTestCase
{

    private int dataBad;
    private int dataGoodG2B;
#if (!OMITBAD)
    private void BadSink()
    {
        int data = dataBad;
        /* POTENTIAL FLAW: Create a Dictionary using data as the initial size.  data may be very large, creating memory issues */
        Dictionary<int, int> dict = new Dictionary<int, int>(data);
    }

    /* uses badsource and badsink */
    public override void Bad()
    {
        int data;
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
