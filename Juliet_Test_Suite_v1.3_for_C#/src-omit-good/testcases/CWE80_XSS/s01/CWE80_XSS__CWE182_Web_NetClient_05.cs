/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__CWE182_Web_NetClient_05.cs
Label Definition File: CWE80_XSS__CWE182_Web.label.xml
Template File: sources-sink-05.tmpl.cs
*/
/*
* @description
* CWE: 80 Cross Site Scripting (XSS)
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded string
* BadSink: Web Display of data in web page after using replaceAll() to remove script tags, which will still allow XSS (CWE 182: Collapse of Data into Unsafe Value)
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE80_XSS
{

class CWE80_XSS__CWE182_Web_NetClient_05 : AbstractTestCaseWeb
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (privateTrue)
        {
            data = ""; /* Initialize data */
            /* read input from WebClient */
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        using (StreamReader sr = new StreamReader(client.OpenRead("http://www.example.org/")))
                        {
                            /* POTENTIAL FLAW: Read data from a web server with WebClient */
                            /* This will be reading the first "line" of the response body,
                            * which could be very long if there are no newlines in the HTML */
                            data = sr.ReadLine();
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page after using Replace() to remove script tags, which will still allow XSS with strings like <scr<script>ipt> (CWE 182: Collapse of Data into Unsafe Value) */
            resp.Write("<br>Bad(): data = " + data.Replace("(<script>)", ""));
        }
    }
#endif //omitbad

}
}
