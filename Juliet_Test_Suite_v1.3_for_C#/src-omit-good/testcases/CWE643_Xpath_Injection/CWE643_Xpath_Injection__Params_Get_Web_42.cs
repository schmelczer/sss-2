/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Params_Get_Web_42.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Runtime.InteropServices;
using System.Xml.XPath;

using System.Web;


namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__Params_Get_Web_42 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    private static string BadSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        return data;
    }

    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data = BadSource(req, resp);
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