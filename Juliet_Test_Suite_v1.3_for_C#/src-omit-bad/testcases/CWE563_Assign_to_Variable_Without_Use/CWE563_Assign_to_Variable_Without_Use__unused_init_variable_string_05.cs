/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_init_variable_string_05.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_init_variable.label.xml
Template File: source-sinks-05.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* Sinks:
*    GoodSink: Use data
*    BadSink : do nothing
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_init_variable_string_05 : AbstractTestCase
{
    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;

#if (!OMITGOOD)
    /* goodB2G1() - use badsource and goodsink by changing privateTrue to privateFalse */
    private void GoodB2G1()
    {
        string data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = "Good";
        if (privateFalse)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: Use data */
            IO.WriteLine(data);
        }
    }

    /* goodB2G2() - use badsource and goodsink by reversing statements in if  */
    private void GoodB2G2()
    {
        string data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = "Good";
        if (privateTrue)
        {
            /* FIX: Use data */
            IO.WriteLine(data);
        }
    }

    public override void Good()
    {
        GoodB2G1();
        GoodB2G2();
    }
#endif //omitgood
}
}
