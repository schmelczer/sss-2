/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_value_string_81_bad.cs
Label Definition File: CWE563_Assign_to_Variable_Without_Use__unused_value.label.xml
Template File: sources-sinks-81_bad.tmpl.cs
*/
/*
 * @description
 * CWE: 563 Assignment to Variable without Use
 * BadSource:  Initialize data
 * GoodSource: Initialize and use data
 * Sinks:
 *    GoodSink: Use data
 *    BadSink : re-initialize and use data
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */
#if (!OMITBAD)

using TestCaseSupport;
using System;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_value_string_81_bad : CWE563_Assign_to_Variable_Without_Use__unused_value_string_81_base
{
    public override void Action(string data )
    {
        /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
        data = "Reinitialize";
        IO.WriteLine(data);
    }
}
}
#endif
