/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_16.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption__sleep.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 400 Uncontrolled Resource Consumption
* BadSource: max_value Set count to a hardcoded value of Integer.MaxValue
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks:
*    GoodSink: Validate count before using it as a parameter in sleep function
*    BadSink : Use count as the parameter for sleep withhout checking it's size first
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Threading;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        while (true)
        {
            /* POTENTIAL FLAW: Set count to Integer.MaxValue */
            count = int.MaxValue;
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: Use count as the input to Thread.Sleep() */
            Thread.Sleep(count);
            break;
        }
    }
#endif //omitbad

}
}
