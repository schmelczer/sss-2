/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_value_StringBuilder_16.cs
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

using System.Text;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_value_StringBuilder_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        while (true)
        {
            /* POTENTIAL FLAW: Initialize, but do not use data */
            data = new StringBuilder("Good");
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
            data = new StringBuilder("Reinitialize");
            IO.WriteLine(data.ToString());
            break;
        }
    }
#endif //omitbad

}
}
