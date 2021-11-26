/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_init_variable_StringBuilder_17.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_init_variable.label.xml
Template File: source-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* Sinks:
*    GoodSink: Use data
*    BadSink : do nothing
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Text;


namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_init_variable_StringBuilder_17 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodB2G() - use badsource and goodsink by changing the conditions on
       the for statements */
    private void GoodB2G()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = new StringBuilder("Good");
        for (int k = 0; k < 1; k++)
        {
            /* FIX: Use data */
            IO.WriteLine(data.ToString());
        }
    }

    public override void Good()
    {
        GoodB2G();
    }
#endif //omitgood
}
}