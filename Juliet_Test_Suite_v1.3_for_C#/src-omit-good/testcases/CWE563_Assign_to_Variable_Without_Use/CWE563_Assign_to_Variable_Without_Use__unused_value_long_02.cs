/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_value_long_02.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_value.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* GoodSource: Initialize and use data
* Sinks:
*    GoodSink: Use data
*    BadSink : re-initialize and use data
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_value_long_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        if (true)
        {
            /* POTENTIAL FLAW: Initialize, but do not use data */
            data = 5L;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0L;
        }
        if (true)
        {
            /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
            data = 10L;
            IO.WriteLine("" + data);
        }
    }
#endif //omitbad

}
}
