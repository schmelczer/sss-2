/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__NetClient_61a.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 117 Improper Output Neutralization for Logs
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    GoodSink: Logging output is neutralized
 *    BadSink : Logging output is not neutralized
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE117_Improper_Output_Neutralization_for_Logs
{
class CWE117_Improper_Output_Neutralization_for_Logs__NetClient_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data = CWE117_Improper_Output_Neutralization_for_Logs__NetClient_61b.BadSource();
        try
        {
            int value = int.Parse(data);
        }
        catch (FormatException exceptNumberFormat)
        {
            /* POTENTIAL FLAW: Logging output is not neutralized */
            IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Failed to parse value = " + data);
        }
    }
#endif //omitbad

}
}
