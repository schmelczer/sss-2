/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Database_for_loop_54c.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-54c.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Database Read count from a database
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: for_loop
 *    GoodSink: Validate count before using it as the loop variant in a for loop
 *    BadSink : Use count as the loop variant in a for loop
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Database_for_loop_54c
{
#if (!OMITBAD)
    public static void BadSink(int count )
    {
        CWE400_Uncontrolled_Resource_Consumption__Database_for_loop_54d.BadSink(count );
    }
#endif


}
}
