/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__Connect_tcp_ArrayList_72b.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-72b.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: ArrayList
 *    BadSink : Create an ArrayList using data as the initial size
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;


namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{
class CWE789_Uncontrolled_Mem_Alloc__Connect_tcp_ArrayList_72b
{
#if (!OMITBAD)
    public static void BadSink(Hashtable dataHashtable )
    {
        int data = (int) dataHashtable[2];
        /* POTENTIAL FLAW: Create an ArrayList using data as the initial size.  data may be very large, creating memory issues */
        ArrayList intArrayList = new ArrayList(data);
    }
#endif


}
}
