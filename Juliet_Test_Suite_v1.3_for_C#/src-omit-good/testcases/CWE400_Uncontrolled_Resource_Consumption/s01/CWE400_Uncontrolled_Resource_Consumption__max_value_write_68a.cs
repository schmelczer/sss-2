/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__max_value_write_68a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: max_value Set count to a hardcoded value of Integer.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__max_value_write_68a : AbstractTestCase
{

    public static int count;
#if (!OMITBAD)
    public override void Bad()
    {
        /* POTENTIAL FLAW: Set count to int.MaxValue */
        count = int.MaxValue;
        CWE400_Uncontrolled_Resource_Consumption__max_value_write_68b.BadSink();
    }
#endif //omitbad

}
}
