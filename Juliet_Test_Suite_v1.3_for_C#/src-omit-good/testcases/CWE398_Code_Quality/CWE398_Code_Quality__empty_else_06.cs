/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_else_06.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_else
*    GoodSink: Else statement contains code
*    BadSink : An empty else statement has no effect
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_else_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_FIVE == 5)
        {
            int x;
            x = (new Random()).Next();
            if (x == 0)
            {
                IO.WriteLine("Inside the else statement");
            }
            /* FLAW: An empty else statement has no effect */
            else
            {
            }
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}
