/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE482_Comparing_Instead_of_Assigning__basic_05.cs
Label Definition File: CWE482_Comparing_Instead_of_Assigning__basic.label.xml
Template File: point-flaw-05.tmpl.cs
*/
/*
* @description
* CWE: 482 Comparing Instead of Assigning
* Sinks:
*    GoodSink: Assigning
*    BadSink : Comparing instead of assigning
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE482_Comparing_Instead_of_Assigning
{
class CWE482_Comparing_Instead_of_Assigning__basic_05 : AbstractTestCase
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
            int zeroOrOne = (new Random()).Next(2);
            bool isZero = false;
            if ((isZero == (zeroOrOne == 0)) == true) /* FLAW: should be (isZero = (zeroOrOne == 0)) */
            {
                IO.WriteLine("zeroOrOne is 0");
            }
            IO.WriteLine("isZero is: " + isZero);
        }
    }
#endif //omitbad

}
}
