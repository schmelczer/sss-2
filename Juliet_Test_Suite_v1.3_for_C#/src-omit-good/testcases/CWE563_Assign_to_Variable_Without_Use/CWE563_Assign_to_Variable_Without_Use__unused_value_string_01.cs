/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_value_string_01.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_value.label.xml
Template File: sources-sinks-01.tmpl.cs
*/
/*
* @description
* CWE: 563 Assignment to Variable without Use
* BadSource:  Initialize data
* GoodSource: Initialize and use data
* Sinks:
*    GoodSink: Use data
*    BadSink : re-initialize and use data
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_value_string_01 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* POTENTIAL FLAW: Initialize, but do not use data */
        data = "Good";
        /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
        data = "Reinitialize";
        IO.WriteLine(data);
    }
#endif //omitbad

}
}
