/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE440_Expected_Behavior_Violation__basic_Exception_05.cs
Label Definition File: CWE440_Expected_Behavior_Violation__basic.label.xml
Template File: point-flaw-05.tmpl.cs
*/
/*
* @description
* CWE: 440 Expected Behavior Violation
* Sinks: Exception
*    GoodSink: Ensure user input is an integer
*    BadSink : Don't ensure that the user input is an integer, thus possibly causing unexepected behavior
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE440_Expected_Behavior_Violation
{
class CWE440_Expected_Behavior_Violation__basic_Exception_05 : AbstractTestCase
{
    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (privateTrue)
        {
            IO.WriteLine("Please enter an integer:");
            string userInput = Console.ReadLine();
            /* FLAW: Don't ensure that the user input is an integer, thus possibly causing unexepected behavior */
            string x = string.Format("{0:0000}", userInput);
        }
    }
#endif //omitbad

}
}
