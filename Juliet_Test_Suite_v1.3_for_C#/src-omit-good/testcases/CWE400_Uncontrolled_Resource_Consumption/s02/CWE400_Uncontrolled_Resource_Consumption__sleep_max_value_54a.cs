/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_54a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption__sleep.label.xml
Template File: sources-sinks-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: max_value Set count to a hardcoded value of Integer.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks:
 *    GoodSink: Validate count before using it as a parameter in sleep function
 *    BadSink : Use count as the parameter for sleep withhout checking it's size first
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_54a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        /* POTENTIAL FLAW: Set count to Integer.MaxValue */
        count = int.MaxValue;
        CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_54b.BadSink(count );
    }
#endif //omitbad

}
}
