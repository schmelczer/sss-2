/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__Params_Get_Web_Dictionary_53c.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-53c.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: Dictionary
 *    BadSink : Create a Dictionary using data as the initial size
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{
class CWE789_Uncontrolled_Mem_Alloc__Params_Get_Web_Dictionary_53c
{
#if (!OMITBAD)
    public static void BadSink(int data , HttpRequest req, HttpResponse resp)
    {
        CWE789_Uncontrolled_Mem_Alloc__Params_Get_Web_Dictionary_53d.BadSink(data , req, resp);
    }
#endif


}
}