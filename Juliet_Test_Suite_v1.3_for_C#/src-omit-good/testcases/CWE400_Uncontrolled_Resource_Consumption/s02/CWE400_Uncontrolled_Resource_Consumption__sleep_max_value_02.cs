/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_02.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption__sleep.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 400 Uncontrolled Resource Consumption
* BadSource: max_value Set count to a hardcoded value of Integer.MaxValue
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks:
*    GoodSink: Validate count before using it as a parameter in sleep function
*    BadSink : Use count as the parameter for sleep withhout checking it's size first
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Threading;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__sleep_max_value_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        if (true)
        {
            /* POTENTIAL FLAW: Set count to Integer.MaxValue */
            count = int.MaxValue;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure count is inititialized before the Sink to avoid compiler errors */
            count = 0;
        }
        if (true)
        {
            /* POTENTIAL FLAW: Use count as the input to Thread.Sleep() */
            Thread.Sleep(count);
        }
    }
#endif //omitbad

}
}
