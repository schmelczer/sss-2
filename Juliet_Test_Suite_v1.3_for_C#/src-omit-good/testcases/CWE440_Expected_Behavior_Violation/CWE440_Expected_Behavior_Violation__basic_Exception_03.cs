/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE440_Expected_Behavior_Violation__basic_Exception_03.cs
Label Definition File: CWE440_Expected_Behavior_Violation__basic.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 440 Expected Behavior Violation
* Sinks: Exception
*    GoodSink: Ensure user input is an integer
*    BadSink : Don't ensure that the user input is an integer, thus possibly causing unexepected behavior
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE440_Expected_Behavior_Violation
{
class CWE440_Expected_Behavior_Violation__basic_Exception_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
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
