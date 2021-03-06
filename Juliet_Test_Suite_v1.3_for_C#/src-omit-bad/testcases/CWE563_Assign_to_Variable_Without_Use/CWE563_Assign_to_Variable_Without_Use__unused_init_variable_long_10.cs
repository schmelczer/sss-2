/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_init_variable_long_10.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_init_variable.label.xml
Template File: source-sinks-10.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* Sinks:
*    GoodSink: Use data
*    BadSink : do nothing
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_init_variable_long_10 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodB2G1() - use badsource and goodsink by changing IO.staticTrue to IO.staticFalse */
    private void GoodB2G1()
    {
        long data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = 5L;
        if (IO.staticFalse)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: Use data */
            IO.WriteLine("" + data);
        }
    }

    /* goodB2G2() - use badsource and goodsink by reversing statements in if  */
    private void GoodB2G2()
    {
        long data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = 5L;
        if (IO.staticTrue)
        {
            /* FIX: Use data */
            IO.WriteLine("" + data);
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
