/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_value_StringBuilder_09.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_value.label.xml
Template File: sources-sinks-09.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* GoodSource: Initialize and use data
* Sinks:
*    GoodSink: Use data
*    BadSink : re-initialize and use data
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_value_StringBuilder_09 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing first IO.STATIC_READONLY_TRUE to IO.STATIC_READONLY_FALSE */
    private void GoodG2B1()
    {
        StringBuilder data;
        if (IO.STATIC_READONLY_FALSE)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        else
        {
            /* FIX: Initialize and use data before it is overwritten */
            data = new StringBuilder("Good");
            IO.WriteLine(data.ToString());
        }
        if (IO.STATIC_READONLY_TRUE)
        {
            /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
            data = new StringBuilder("Reinitialize");
            IO.WriteLine(data.ToString());
        }
    }

    /* GoodG2B2() - use goodsource and badsink by reversing statements in first if */
    private void GoodG2B2()
    {
        StringBuilder data;
        if (IO.STATIC_READONLY_TRUE)
        {
            /* FIX: Initialize and use data before it is overwritten */
            data = new StringBuilder("Good");
            IO.WriteLine(data.ToString());
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (IO.STATIC_READONLY_TRUE)
        {
            /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
            data = new StringBuilder("Reinitialize");
            IO.WriteLine(data.ToString());
        }
    }

    /* goodB2G1() - use badsource and goodsink by changing second IO.STATIC_READONLY_TRUE to IO.STATIC_READONLY_FALSE */
    private void GoodB2G1()
    {
        StringBuilder data;
        if (IO.STATIC_READONLY_TRUE)
        {
            /* POTENTIAL FLAW: Initialize, but do not use data */
            data = new StringBuilder("Good");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (IO.STATIC_READONLY_FALSE)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: Use data without over-writing its value */
            IO.WriteLine(data.ToString());
        }
    }

    /* goodB2G2() - use badsource and goodsink by reversing statements in second if  */
    private void GoodB2G2()
    {
        StringBuilder data;
        if (IO.STATIC_READONLY_TRUE)
        {
            /* POTENTIAL FLAW: Initialize, but do not use data */
            data = new StringBuilder("Good");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (IO.STATIC_READONLY_TRUE)
        {
            /* FIX: Use data without over-writing its value */
            IO.WriteLine(data.ToString());
        }
    }

    public override void Good()
    {
        GoodG2B1();
        GoodG2B2();
        GoodB2G1();
        GoodB2G2();
    }
#endif //omitgood
}
}
