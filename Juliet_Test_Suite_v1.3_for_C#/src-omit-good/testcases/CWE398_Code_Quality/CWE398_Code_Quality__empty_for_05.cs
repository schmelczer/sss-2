/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_for_05.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-05.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_for
*    GoodSink: For statement contains code
*    BadSink : An empty for statement has no effect
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_for_05 : AbstractTestCase
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
            /* FLAW: An empty for statement has no effect */
            for (int i = 0; i < 10; i++)
            {
            }
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}