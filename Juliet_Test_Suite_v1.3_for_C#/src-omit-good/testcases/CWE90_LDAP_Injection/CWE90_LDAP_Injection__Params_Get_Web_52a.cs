/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Params_Get_Web_52a.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-52a.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
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

class CWE90_LDAP_Injection__Params_Get_Web_52a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        CWE90_LDAP_Injection__Params_Get_Web_52b.BadSink(data , req, resp);
    }
#endif //omitbad

}
}
