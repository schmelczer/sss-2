/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__sleep_Environment_04.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption__sleep.label.xml
Template File: sources-sinks-04.tmpl.cs
*/
/*
* @description
* CWE: 400 Uncontrolled Resource Consumption
* BadSource: Environment Read count from an environment variable
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks:
*    GoodSink: Validate count before using it as a parameter in sleep function
*    BadSink : Use count as the parameter for sleep withhout checking it's size first
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Threading;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__sleep_Environment_04 : AbstractTestCase
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        if (PRIVATE_CONST_TRUE)
        {
            count = int.MinValue; /* Initialize count */
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read count from an environment variable */
            {
                string stringNumber = Environment.GetEnvironmentVariable("ADD");
                if (stringNumber != null) // avoid NPD incidental warnings
                {
                    try
                    {
                        count = int.Parse(stringNumber.Trim());
                    }
                    catch (FormatException exceptNumberFormat)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing count from string");
                    }
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure count is inititialized before the Sink to avoid compiler errors */
            count = 0;
        }
        if (PRIVATE_CONST_TRUE)
        {
            /* POTENTIAL FLAW: Use count as the input to Thread.Sleep() */
            Thread.Sleep(count);
        }
    }
#endif //omitbad

}
}
