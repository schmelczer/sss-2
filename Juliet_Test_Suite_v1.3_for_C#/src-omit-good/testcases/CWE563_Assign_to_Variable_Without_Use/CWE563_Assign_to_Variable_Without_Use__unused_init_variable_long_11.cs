/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_init_variable_long_11.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_init_variable.label.xml
Template File: source-sinks-11.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* Sinks:
*    GoodSink: Use data
*    BadSink : do nothing
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_init_variable_long_11 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = 5L;
        if (IO.StaticReturnsTrue())
        {
            /* FLAW: Do not use the variable */
            /* do nothing */
            ; /* empty statement needed for some flow variants */
        }
    }
#endif //omitbad

}
}
