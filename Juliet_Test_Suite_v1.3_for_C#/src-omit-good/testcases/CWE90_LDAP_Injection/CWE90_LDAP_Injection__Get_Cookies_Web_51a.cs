/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Get_Cookies_Web_51a.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * BadSink:  data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE90_LDAP_Injection
{

class CWE90_LDAP_Injection__Get_Cookies_Web_51a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
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
        CWE90_LDAP_Injection__Get_Cookies_Web_51b.BadSink(data , req, resp );
    }
#endif //omitbad

}
}
