/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_init_variable_int_15.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_init_variable.label.xml
Template File: source-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* Sinks:
*    GoodSink: Use data
*    BadSink : do nothing
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_init_variable_int_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = 5;
        switch (7)
        {
        case 7:
            /* FLAW: Do not use the variable */
            /* do nothing */
            ; /* empty statement needed for some flow variants */
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
