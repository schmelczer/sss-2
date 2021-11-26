/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Params_Get_Web_53b.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-53b.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE90_LDAP_Injection
{
class CWE90_LDAP_Injection__Params_Get_Web_53b
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE90_LDAP_Injection__Params_Get_Web_53c.BadSink(data , req, resp);
    }
#endif


}
}