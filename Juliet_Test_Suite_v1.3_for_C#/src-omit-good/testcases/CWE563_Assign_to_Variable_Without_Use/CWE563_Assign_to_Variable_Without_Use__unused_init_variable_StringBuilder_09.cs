/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_init_variable_StringBuilder_09.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_init_variable.label.xml
Template File: source-sinks-09.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* Sinks:
*    GoodSink: Use data
*    BadSink : do nothing
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Text;


namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_init_variable_StringBuilder_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = new StringBuilder("Good");
        if (IO.STATIC_READONLY_TRUE)
        {
            /* FLAW: Do not use the variable */
            /* do nothing */
            ; /* empty statement needed for some flow variants */
        }
    }
#endif //omitbad

}
}
