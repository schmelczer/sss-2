/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_ReadLine_15.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-15.tmpl.cs
*/
/*
* @description
* CWE: 81 Cross Site Scripting (XSS) in Error Message
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: A hardcoded string
* BadSink: ErrorStatusCode XSS in StatusCode
* Flow Variant: 15 Control flow: switch(6)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_ReadLine_15 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data = null;
        switch (6)
        {
        case 6:
            data = ""; /* Initialize data */
            {
                /* read user input from console with ReadLine */
                try
                {
                    /* POTENTIAL FLAW: Read data from the console using ReadLine */
                    data = Console.ReadLine();
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: script code (e.g. id=<script>alert('xss')</script>) is sent to the client; */
            resp.StatusCode = 404;
            resp.StatusDescription = "<br>Bad() - Parameter name has value " + data;
        }
    }
#endif //omitbad

}
}
