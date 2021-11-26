/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Params_Get_Web_54a.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE90_LDAP_Injection
{

class CWE90_LDAP_Injection__Params_Get_Web_54a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        CWE90_LDAP_Injection__Params_Get_Web_54b.BadSink(data , req, resp);
    }
#endif //omitbad

}
}
