/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE483_Incorrect_Block_Delimitation__semicolon_04.cs
Label Definition File: CWE483_Incorrect_Block_Delimitation.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 483 Incorrect Block Delimitation
* Sinks: semicolon
*    GoodSink: Absence of suspicious semicolon
*    BadSink : Suspicious semicolon before the if statement brace
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE483_Incorrect_Block_Delimitation
{
class CWE483_Incorrect_Block_Delimitation__semicolon_04 : AbstractTestCase
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
