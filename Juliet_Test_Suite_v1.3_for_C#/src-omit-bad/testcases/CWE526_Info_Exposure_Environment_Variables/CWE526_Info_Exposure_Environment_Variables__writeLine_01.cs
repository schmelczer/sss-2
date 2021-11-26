/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE526_Info_Exposure_Environment_Variables__writeLine_01.cs
Label Definition File: CWE526_Info_Exposure_Environment_Variables.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 526 Information Exposure Through Environment Variables
* Sinks: writeLine
*    GoodSink: no exposing
*    BadSink : expose the path variable to the user
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE526_Info_Exposure_Environment_Variables
{
class CWE526_Info_Exposure_Environment_Variables__writeLine_01 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        Good1();
    }

    private void Good1()
    {
        /* FIX: error message is general */
        IO.WriteLine("Not in path");
    }
#endif //omitgood
}
}
