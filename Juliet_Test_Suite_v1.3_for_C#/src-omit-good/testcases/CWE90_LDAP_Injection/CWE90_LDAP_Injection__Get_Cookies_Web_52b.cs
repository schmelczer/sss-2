/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Get_Cookies_Web_52b.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-52b.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE90_LDAP_Injection
{
class CWE90_LDAP_Injection__Get_Cookies_Web_52b
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE90_LDAP_Injection__Get_Cookies_Web_52c.BadSink(data , req, resp);
    }
#endif


}
}
