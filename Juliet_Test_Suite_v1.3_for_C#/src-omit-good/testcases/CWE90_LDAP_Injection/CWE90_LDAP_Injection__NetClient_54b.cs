/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__NetClient_54b.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-54b.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: NetClient Read data from a web server with WebClient
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
class CWE90_LDAP_Injection__NetClient_54b
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE90_LDAP_Injection__NetClient_54c.BadSink(data );
    }
#endif


}
}
