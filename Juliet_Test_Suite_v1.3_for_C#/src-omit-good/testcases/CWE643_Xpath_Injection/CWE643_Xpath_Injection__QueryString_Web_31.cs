/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__QueryString_Web_31.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-31.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.Runtime.InteropServices;
using System.Xml.XPath;

using System.Web;


namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__QueryString_Web_31 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string dataCopy;
        {
            string data;
            data = ""; /* initialize data in case id is not in query string */
            /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
            {
                if (req.QueryString["id"] != null)
                {
                    data = req.QueryString["id"];
                }
            }
            dataCopy = data;
        }
        {
            string data = dataCopy;
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