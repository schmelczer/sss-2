/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_uninit_variable_string_01.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_uninit_variable.label.xml
Template File: source-sinks-01.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  don't initialize data
* Sinks:
*    GoodSink: init and use data
*    BadSink : do nothing
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_uninit_variable_string_01 : AbstractTestCase
{
#if (!OMITBAD)
    /* use badsource and badsink */
    public override void Bad()
    {
        string data;
        /* POTENTIAL FLAW: Don't initialize or use data */
        ; /* empty statement needed for some flow variants */
        /* FLAW: Don't initialize or use data */
        /* do nothing */
        ; /* empty statement needed for some flow variants */
    }
#endif //omitbad

}
}
