/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_value_int_10.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_value.label.xml
Template File: sources-sinks-10.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* GoodSource: Initialize and use data
* Sinks:
*    GoodSink: Use data
*    BadSink : re-initialize and use data
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_value_int_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        if (IO.staticTrue)
        {
            /* POTENTIAL FLAW: Initialize, but do not use data */
            data = 5;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (IO.staticTrue)
        {
            /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
            data = 10;
            IO.WriteLine("" + data);
        }
    }
#endif //omitbad

}
}
