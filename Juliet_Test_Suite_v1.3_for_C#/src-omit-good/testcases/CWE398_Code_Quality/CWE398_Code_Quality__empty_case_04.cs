/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_case_04.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_case
*    GoodSink: Case statement contains code
*    BadSink : An empty case statement has no effect
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_case_04 : AbstractTestCase
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
        if (PRIVATE_CONST_TRUE)
        {
            int x = (new Random()).Next();
            switch (x)
            {
                /* FLAW: An empty case statement has no effect */
            case 0:
                break;
            default:
                IO.WriteLine("Inside the default statement");
                break;
            }
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}
