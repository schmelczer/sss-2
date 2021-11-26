/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE481_Assigning_Instead_of_Comparing__basic_02.cs
Label Definition File: CWE481_Assigning_Instead_of_Comparing__basic.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 481 Assigning Instead of Comparing
* Sinks:
*    GoodSink: Comparing
*    BadSink : Assigning instead of comparing
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE481_Assigning_Instead_of_Comparing
{
class CWE481_Assigning_Instead_of_Comparing__basic_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            int zeroOrOne = (new Random()).Next(2);
            bool isZero = (zeroOrOne == 0);
            if (isZero = true) /* FLAW: should be == and INCIDENTIAL CWE 571 Expression Is Always True */
            {
                IO.WriteLine("zeroOrOne is 0");
            }
            IO.WriteLine("isZero is: " + isZero);
        }
    }
#endif //omitbad

}
}
