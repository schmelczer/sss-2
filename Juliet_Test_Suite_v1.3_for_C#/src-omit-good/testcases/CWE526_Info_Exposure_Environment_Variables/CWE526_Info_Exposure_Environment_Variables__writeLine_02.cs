/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE526_Info_Exposure_Environment_Variables__writeLine_02.cs
Label Definition File: CWE526_Info_Exposure_Environment_Variables.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 526 Information Exposure Through Environment Variables
* Sinks: writeLine
*    GoodSink: no exposing
*    BadSink : expose the path variable to the user
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE526_Info_Exposure_Environment_Variables
{
class CWE526_Info_Exposure_Environment_Variables__writeLine_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            /* FLAW: environment variable information exposed */
            IO.WriteLine("Not in path: " + Environment.GetEnvironmentVariable("PATH"));
        }
    }
#endif //omitbad

}
}
