/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Random_for_loop_02.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 400 Uncontrolled Resource Consumption
* BadSource: Random Set count to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: for_loop
*    GoodSink: Validate count before using it as the loop variant in a for loop
*    BadSink : Use count as the loop variant in a for loop
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Random_for_loop_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        if (true)
        {
            /* POTENTIAL FLAW: Set count to a random value */
            count = (new Random()).Next();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure count is inititialized before the Sink to avoid compiler errors */
            count = 0;
        }
        if (true)
        {
            int i = 0;
            /* POTENTIAL FLAW: For loop using count as the loop variant and no validation */
            for (i = 0; i < count; i++)
            {
                IO.WriteLine("Hello");
            }
        }
    }
#endif //omitbad

}
}
