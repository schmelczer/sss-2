/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Get_Cookies_Web_52a.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-52a.tmpl.cs
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

class CWE90_LDAP_Injection__Get_Cookies_Web_52a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE90_LDAP_Injection__Get_Cookies_Web_52b.GoodG2BSink(data , req, resp);
    }
#endif //omitgood
}
}
