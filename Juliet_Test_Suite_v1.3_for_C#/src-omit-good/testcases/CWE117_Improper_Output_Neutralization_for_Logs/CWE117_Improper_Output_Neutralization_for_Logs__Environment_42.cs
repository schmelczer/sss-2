/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__Environment_42.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 117 Improper Output Neutralization for Logs
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    GoodSink: Logging output is neutralized
 *    BadSink : Logging output is not neutralized
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE117_Improper_Output_Neutralization_for_Logs
{
class CWE117_Improper_Output_Neutralization_for_Logs__Environment_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static string BadSource()
    {
        string data;
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        data = Environment.GetEnvironmentVariable("ADD");
        return data;
    }

    public override void Bad()
    {
        string data = BadSource();
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
