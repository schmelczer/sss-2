/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE563_Assign_to_Variable_Without_Use__unused_value_StringBuilder_12.cs
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

using System.Text;

namespace testcases.CWE563_Assign_to_Variable_Without_Use
{
class CWE563_Assign_to_Variable_Without_Use__unused_value_StringBuilder_12 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: Initialize, but do not use data */
            data = new StringBuilder("Good");
        }
        else
        {
            /* FIX: Initialize and use data before it is overwritten */
            data = new StringBuilder("Good");
            IO.WriteLine(data.ToString());
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: Possibly over-write the initial value of data before using it */
            data = new StringBuilder("Reinitialize");
            IO.WriteLine(data.ToString());
        }
        else
        {
            /* FIX: Use data without over-writing its value */
            IO.WriteLine(data.ToString());
        }
    }
#endif //omitbad

}
}
