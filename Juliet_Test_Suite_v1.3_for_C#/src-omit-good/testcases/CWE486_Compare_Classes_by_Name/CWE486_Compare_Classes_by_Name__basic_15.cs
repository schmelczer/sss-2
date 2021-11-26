/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE486_Compare_Classes_by_Name__basic_15.cs
Label Definition File: CWE486_Compare_Classes_by_Name__basic.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 486 Compare Classes by Name
* Sinks:
*    GoodSink: properly compare class
*    BadSink : Compare class names
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE486_Compare_Classes_by_Name
{
class CWE486_Compare_Classes_by_Name__basic_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        switch (7)
        {
        case 7:
            /* FLAW: Differentiating by name is not enough, since different classes in different packages may use the same name */
            testcases.CWE486_Compare_Classes_by_Name.HelperClass.CWE486_Compare_Classes_by_Name__Helper helperClass = new testcases.CWE486_Compare_Classes_by_Name.HelperClass.CWE486_Compare_Classes_by_Name__Helper();
            testcases.CWE486_Compare_Classes_by_Name.CWE486_Compare_Classes_by_Name__Helper helperClassRoot = new testcases.CWE486_Compare_Classes_by_Name.CWE486_Compare_Classes_by_Name__Helper();
            if (helperClassRoot.GetType().Name.Equals(helperClass.GetType().Name))
            {
                IO.WriteLine("Classes are the same");
            }
            else
            {
                /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
                IO.WriteLine("Classes are different");
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
