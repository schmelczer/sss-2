/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__MaxValue_ArrayList_66a.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: MaxValue Set data to a hardcoded value of Integer.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: ArrayList
 *    BadSink : Create an ArrayList using data as the initial size
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__MaxValue_ArrayList_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override  void Bad()
    {
        int data;
        /* FLAW: Set data to Integer.MaxValue */
        data = int.MaxValue;
        int[] dataArray = new int[5];
        dataArray[2] = data;
        CWE789_Uncontrolled_Mem_Alloc__MaxValue_ArrayList_66b.BadSink(dataArray  );
    }
#endif //omitbad

}
}
