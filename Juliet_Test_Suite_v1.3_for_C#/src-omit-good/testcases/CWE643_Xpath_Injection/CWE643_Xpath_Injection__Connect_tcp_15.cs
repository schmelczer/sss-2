/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Connect_tcp_15.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 643 Xpath Injection
* BadSource: Connect_tcp Read data using an outbound tcp connection
* GoodSource: A hardcoded string
* Sinks:
*    GoodSink: validate input through SecurityElement.Escape
*    BadSink : user input is used without validate
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Runtime.InteropServices;
using System.Xml.XPath;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__Connect_tcp_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        switch (6)
        {
        case 6:
            data = ""; /* Initialize data */
            /* Read data using an outbound tcp connection */
            {
                try
                {
                    /* Read data using an outbound tcp connection */
                    using (TcpClient tcpConn = new TcpClient("host.example.org", 39544))
                    {
                        /* read input from socket */
                        using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                        {
                            /* POTENTIAL FLAW: Read data using an outbound tcp connection */
                            data = sr.ReadLine();
                        }
                    }
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
        switch (7)
        {
        case 7:
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
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}