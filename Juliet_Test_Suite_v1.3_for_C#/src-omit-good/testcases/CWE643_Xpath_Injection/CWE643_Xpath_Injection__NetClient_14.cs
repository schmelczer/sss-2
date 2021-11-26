/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__NetClient_14.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-14.tmpl.cs
*/
/*
* @description
* CWE: 643 Xpath Injection
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded string
* Sinks:
*    GoodSink: validate input through SecurityElement.Escape
*    BadSink : user input is used without validate
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Runtime.InteropServices;
using System.Xml.XPath;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__NetClient_14 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        if (IO.staticFive==5)
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
        if (IO.staticFive==5)
        {
            string xmlFile = null;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                /* running on Windows */
                xmlFile = "..\\..\\CWE643_Xpath_Injection__Helper.xml";
            }
            else
            {
                /* running on non-Windows */
                xmlFile = "../../CWE643_Xpath_Injection__Helper.xml";
            }
            if (data != null)
            {
                /* assume username||password as source */
                string[] tokens = data.Split("||".ToCharArray());
                if (tokens.Length < 2)
                {
                    return;
                }
                string username = tokens[0];
                string password = tokens[1];
                /* build xpath */
                XPathDocument inputXml = new XPathDocument(xmlFile);
                XPathNavigator xPath = inputXml.CreateNavigator();
                /* INCIDENTAL: CWE180 Incorrect Behavior Order: Validate Before Canonicalize
                 *     The user input should be canonicalized before validation. */
                /* POTENTIAL FLAW: user input is used without validate */
                string query = "//users/user[name/text()='" + username +
                               "' and pass/text()='" + password + "']" +
                               "/secret/text()";
                string secret = (string)xPath.Evaluate(query);
            }
        }
    }
#endif //omitbad

}
}
