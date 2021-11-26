/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_block_01.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_block
*    GoodSink: Include some code inside a block
*    BadSink : An empty code block has no effect
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_block_01 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        /* FLAW: The empty block on the next line has no effect */
        {
        }
        IO.WriteLine("Hello from Bad()");
    }
#endif //omitbad

}
}
