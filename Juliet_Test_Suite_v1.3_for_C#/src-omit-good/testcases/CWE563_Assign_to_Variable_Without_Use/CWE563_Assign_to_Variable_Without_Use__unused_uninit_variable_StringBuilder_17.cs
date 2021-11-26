/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_uninit_variable_StringBuilder_17.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_uninit_variable.label.xml
Template File: source-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  don't initialize data
* Sinks:
*    GoodSink: init and use data
*    BadSink : do nothing
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_uninit_variable_StringBuilder_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: Don't initialize or use data */
        ; /* empty statement needed for some flow variants */
        for (int j = 0; j < 1; j++)
        {
            /* FLAW: Don't initialize or use data */
            /* do nothing */
            ; /* empty statement needed for some flow variants */
        }
    }
#endif //omitbad

}
}
