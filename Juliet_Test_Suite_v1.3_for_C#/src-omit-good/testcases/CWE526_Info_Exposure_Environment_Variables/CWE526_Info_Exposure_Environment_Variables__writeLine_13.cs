/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE526_Info_Exposure_Environment_Variables__writeLine_13.cs
Label Definition File: CWE526_Info_Exposure_Environment_Variables.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 526 Information Exposure Through Environment Variables
* Sinks: writeLine
*    GoodSink: no exposing
*    BadSink : expose the path variable to the user
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE526_Info_Exposure_Environment_Variables
{
class CWE526_Info_Exposure_Environment_Variables__writeLine_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_FIVE == 5)
        {
            /* FLAW: environment variable information exposed */
            IO.WriteLine("Not in path: " + Environment.GetEnvironmentVariable("PATH"));
        }
    }
#endif //omitbad

}
}
