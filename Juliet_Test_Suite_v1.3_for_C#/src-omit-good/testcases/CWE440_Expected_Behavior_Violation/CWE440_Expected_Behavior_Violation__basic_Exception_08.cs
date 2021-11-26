/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE440_Expected_Behavior_Violation__basic_Exception_08.cs
Label Definition File: CWE440_Expected_Behavior_Violation__basic.label.xml
Template File: point-flaw-08.tmpl.cs
*/
/*
* @description
* CWE: 440 Expected Behavior Violation
* Sinks: Exception
*    GoodSink: Ensure user input is an integer
*    BadSink : Don't ensure that the user input is an integer, thus possibly causing unexepected behavior
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE440_Expected_Behavior_Violation
{
class CWE440_Expected_Behavior_Violation__basic_Exception_08 : AbstractTestCase
{
    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false.
     */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        if (PrivateReturnsTrue())
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
