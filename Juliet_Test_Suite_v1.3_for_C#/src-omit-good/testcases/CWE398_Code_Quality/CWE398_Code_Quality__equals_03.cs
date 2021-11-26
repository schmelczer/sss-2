/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__equals_03.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: equals
*    GoodSink: Set a variable equal to another variable
*    BadSink : Setting a variable equal to itself has no effect
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__equals_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            int intOne = 1;
            IO.WriteLine(intOne);
            /* FLAW: The statement below has no effect since it is setting a variable to itself */
            intOne = intOne;
            IO.WriteLine(intOne);
        }
    }
#endif //omitbad

}
}
