/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Params_Get_Web_22b.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE90_LDAP_Injection
{

class CWE90_LDAP_Injection__Params_Get_Web_22b
{
#if (!OMITBAD)
    public static string BadSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE90_LDAP_Injection__Params_Get_Web_22a.badPublicStatic)
        {
            /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
            data = req.Params.Get("name");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif


}
}
