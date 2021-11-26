/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE482_Comparing_Instead_of_Assigning__basic_03.cs
Label Definition File: CWE482_Comparing_Instead_of_Assigning__basic.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 482 Comparing Instead of Assigning
* Sinks:
*    GoodSink: Assigning
*    BadSink : Comparing instead of assigning
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE482_Comparing_Instead_of_Assigning
{
class CWE482_Comparing_Instead_of_Assigning__basic_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
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
