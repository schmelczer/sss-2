/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__Get_Cookies_Web_09.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-09.tmpl.cs
*/
/*
* @description
* CWE: 117 Improper Output Neutralization for Logs
* BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
* GoodSource: A hardcoded string
* Sinks: readFile
*    GoodSink: Logging output is neutralized
*    BadSink : Logging output is not neutralized
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE117_Improper_Output_Neutralization_for_Logs
{
class CWE117_Improper_Output_Neutralization_for_Logs__Get_Cookies_Web_09 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (IO.STATIC_READONLY_TRUE)
        {
            data = ""; /* initialize data in case there are no cookies */
            /* Read data from cookies */
            {
                HttpCookieCollection cookieSources = req.Cookies;
                if (cookieSources != null)
                {
                    /* POTENTIAL FLAW: Read data from the first cookie value */
                    data = cookieSources[0].Value;
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (IO.STATIC_READONLY_TRUE)
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
