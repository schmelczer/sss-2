/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_for_loop_68b.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: for_loop
 *    GoodSink: Validate count before using it as the loop variant in a for loop
 *    BadSink : Use count as the loop variant in a for loop
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_for_loop_68b
{
#if (!OMITBAD)
    public static void BadSink(HttpRequest req, HttpResponse resp)
    {
        int count = CWE400_Uncontrolled_Resource_Consumption__QueryString_Web_for_loop_68a.count;
        int i = 0;
        /* POTENTIAL FLAW: For loop using count as the loop variant and no validation */
        for (i = 0; i < count; i++)
        {
            IO.WriteLine("Hello");
        }
    }
#endif


}
}
