/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__Environment_10.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-10.tmpl.cs
*/
/*
* @description
* CWE: 117 Improper Output Neutralization for Logs
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded string
* Sinks: readFile
*    GoodSink: Logging output is neutralized
*    BadSink : Logging output is not neutralized
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE117_Improper_Output_Neutralization_for_Logs
{
class CWE117_Improper_Output_Neutralization_for_Logs__Environment_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        if (IO.staticTrue)
        {
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            data = Environment.GetEnvironmentVariable("ADD");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (IO.staticTrue)
        {
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
    }
#endif //omitbad

}
}
