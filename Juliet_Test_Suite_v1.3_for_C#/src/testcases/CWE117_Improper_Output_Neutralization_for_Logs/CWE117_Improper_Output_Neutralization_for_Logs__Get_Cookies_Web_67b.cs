/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__Get_Cookies_Web_67b.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 117 Improper Output Neutralization for Logs
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    GoodSink: Logging output is neutralized
 *    BadSink : Logging output is not neutralized
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE117_Improper_Output_Neutralization_for_Logs
{
class CWE117_Improper_Output_Neutralization_for_Logs__Get_Cookies_Web_67b
{
#if (!OMITBAD)
    public static void BadSink(CWE117_Improper_Output_Neutralization_for_Logs__Get_Cookies_Web_67a.Container dataContainer , HttpRequest req, HttpResponse resp)
    {
        string data = dataContainer.containerOne;
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
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(CWE117_Improper_Output_Neutralization_for_Logs__Get_Cookies_Web_67a.Container dataContainer , HttpRequest req, HttpResponse resp)
    {
        string data = dataContainer.containerOne;
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

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(CWE117_Improper_Output_Neutralization_for_Logs__Get_Cookies_Web_67a.Container dataContainer , HttpRequest req, HttpResponse resp)
    {
        string data = dataContainer.containerOne;
        try
        {
            int value = int.Parse(data);
        }
        catch (FormatException exceptNumberFormat)
        {
            /* FIX: Logging output is neutralized */
            IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Failed to parse value. Exception: " + exceptNumberFormat);
        }
    }
#endif
}
}
