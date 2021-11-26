/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_block_02.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_block
*    GoodSink: Include some code inside a block
*    BadSink : An empty code block has no effect
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_block_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            /* FLAW: The empty block on the next line has no effect */
            {
            }
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}
