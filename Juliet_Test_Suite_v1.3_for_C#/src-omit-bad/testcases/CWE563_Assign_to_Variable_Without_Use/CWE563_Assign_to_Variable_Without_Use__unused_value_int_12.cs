/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_value_int_12.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_value.label.xml
Template File: sources-sinks-12.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* GoodSource: Initialize and use data
* Sinks:
*    GoodSink: Use data
*    BadSink : re-initialize and use data
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_value_int_12 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink by changing the first "if" so that
     * both branches use the GoodSource */
    private void GoodG2B()
    {
        int data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: Initialize and use data before it is overwritten */
            data = 5;
            IO.WriteLine("" + data);
        }
        else
        {
            /* FIX: Initialize and use data before it is overwritten */
            data = 5;
            IO.WriteLine("" + data);
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
            data = 10;
            IO.WriteLine("" + data);
        }
        else
        {
            /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
            data = 10;
            IO.WriteLine("" + data);
        }
    }

    /* goodB2G() - use badsource and goodsink by changing the second "if" so that
     * both branches use the GoodSink */
    private void GoodB2G()
    {
        int data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: Initialize, but do not use data */
            data = 5;
        }
        else
        {
            /* POTENTIAL FLAW: Initialize, but do not use data */
            data = 5;
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: Use data without over-writing its value */
            IO.WriteLine("" + data);
        }
        else
        {
            /* FIX: Use data without over-writing its value */
            IO.WriteLine("" + data);
        }
    }

    public override void Good()

    {
        GoodG2B();
        GoodB2G();
    }
#endif //omitgood
}
}
