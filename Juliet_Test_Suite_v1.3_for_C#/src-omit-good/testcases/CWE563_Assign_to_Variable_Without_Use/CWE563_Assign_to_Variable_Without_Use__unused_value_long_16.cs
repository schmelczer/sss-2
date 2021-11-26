/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_value_long_16.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_value.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* GoodSource: Initialize and use data
* Sinks:
*    GoodSink: Use data
*    BadSink : re-initialize and use data
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_value_long_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        while (true)
        {
            /* POTENTIAL FLAW: Initialize, but do not use data */
            data = 5L;
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
            data = 10L;
            IO.WriteLine("" + data);
            break;
        }
    }
#endif //omitbad

}
}
