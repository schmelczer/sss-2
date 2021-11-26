/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE483_Incorrect_Block_Delimitation__semicolon_06.cs
Label Definition File: CWE483_Incorrect_Block_Delimitation.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 483 Incorrect Block Delimitation
* Sinks: semicolon
*    GoodSink: Absence of suspicious semicolon
*    BadSink : Suspicious semicolon before the if statement brace
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE483_Incorrect_Block_Delimitation
{
class CWE483_Incorrect_Block_Delimitation__semicolon_06 : AbstractTestCase
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
            int x, y;
            x = (new Random()).Next(3);
            y = 0;
            /* FLAW: Suspicious semicolon before the if statement brace */
            if (x == 0) ;
            {
                IO.WriteLine("x == 0");
                y = 1; /* do something other than just printing in block */
            }
            IO.WriteLine(y);
        }
    }
#endif //omitbad

}
}
