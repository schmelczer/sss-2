/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__QueryString_Web_61a.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Runtime.InteropServices;
using System.Xml.XPath;

using System.Web;

namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__QueryString_Web_61a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data = CWE643_Xpath_Injection__QueryString_Web_61b.BadSource(req, resp);
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
#endif //omitbad

}
}