/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE481_Assigning_Instead_of_Comparing__basic_13.cs
Label Definition File: CWE481_Assigning_Instead_of_Comparing__basic.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 481 Assigning Instead of Comparing
* Sinks:
*    GoodSink: Comparing
*    BadSink : Assigning instead of comparing
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE481_Assigning_Instead_of_Comparing
{
class CWE481_Assigning_Instead_of_Comparing__basic_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_FIVE == 5)
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
