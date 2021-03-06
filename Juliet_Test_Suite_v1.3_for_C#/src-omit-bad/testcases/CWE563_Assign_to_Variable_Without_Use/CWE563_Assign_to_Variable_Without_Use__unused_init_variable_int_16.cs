/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_init_variable_int_16.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_init_variable.label.xml
Template File: source-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* Sinks:
*    GoodSink: Use data
*    BadSink : do nothing
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_init_variable_int_16 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodB2G() - use badsource and goodsink */
    private void GoodB2G()
    {
        int data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = 5;
        while (true)
        {
            /* FIX: Use data */
            IO.WriteLine("" + data);
            break;
        }
    }

    public override void Good()
    {
        GoodB2G();
    }
#endif //omitgood
}
}
