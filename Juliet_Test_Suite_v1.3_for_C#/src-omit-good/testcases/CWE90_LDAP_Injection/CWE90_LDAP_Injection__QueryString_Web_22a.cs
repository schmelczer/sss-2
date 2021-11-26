/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__QueryString_Web_22a.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.DirectoryServices;

using System.Web;

namespace testcases.CWE90_LDAP_Injection
{
class CWE90_LDAP_Injection__QueryString_Web_22a : AbstractTestCaseWeb
{

    /* The public static variable below is used to drive control flow in the source function.
     * The public static variable mimics a global variable in the C/C++ language family. */
    public static bool badPublicStatic = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        badPublicStatic = true;
        data = CWE90_LDAP_Injection__QueryString_Web_22b.BadSource(req, resp);
        using (DirectoryEntry de = new DirectoryEntry())
        {
            /* POTENTIAL FLAW: data concatenated into LDAP search, which could result in LDAP Injection */
            using (DirectorySearcher search = new DirectorySearcher(de))
            {
                search.Filter = "(&(objectClass=user)(employeename=" + data + "))";
                search.PropertiesToLoad.Add("mail");
                search.PropertiesToLoad.Add("telephonenumber");
                SearchResult sresult = search.FindOne();
            }
        }
    }
#endif //omitbad
    /* The public static variables below are used to drive control flow in the source functions.
     * The public static variable mimics a global variable in the C/C++ language family. */
    public static bool goodG2B1PublicStatic = false;
    public static bool GoodG2B2PublicStatic = false;

}
}
