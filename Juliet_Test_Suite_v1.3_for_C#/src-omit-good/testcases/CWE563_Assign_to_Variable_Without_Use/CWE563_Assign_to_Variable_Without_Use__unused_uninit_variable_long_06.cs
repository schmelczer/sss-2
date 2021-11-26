/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_uninit_variable_long_06.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_uninit_variable.label.xml
Template File: source-sinks-06.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  don't initialize data
* Sinks:
*    GoodSink: init and use data
*    BadSink : do nothing
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_uninit_variable_long_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        /* POTENTIAL FLAW: Don't initialize or use data */
        ; /* empty statement needed for some flow variants */
        if (PRIVATE_CONST_FIVE == 5)
        {
            /* FLAW: Don't initialize or use data */
            /* do nothing */
            ; /* empty statement needed for some flow variants */
        }
    }
#endif //omitbad

}
}
