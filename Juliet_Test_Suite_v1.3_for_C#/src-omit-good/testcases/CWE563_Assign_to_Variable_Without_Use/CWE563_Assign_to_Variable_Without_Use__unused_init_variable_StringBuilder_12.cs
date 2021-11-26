/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_init_variable_StringBuilder_12.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_init_variable.label.xml
Template File: source-sinks-12.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* Sinks:
*    GoodSink: Use data
*    BadSink : do nothing
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Text;


namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_init_variable_StringBuilder_12 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = new StringBuilder("Good");
        if (IO.StaticReturnsTrueOrFalse())
        {
            /* FLAW: Do not use the variable */
            /* do nothing */
            ; /* empty statement needed for some flow variants */
        }
        else
        {
            /* FIX: Use data */
            IO.WriteLine(data.ToString());
        }
    }
#endif //omitbad

}
}
