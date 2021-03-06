/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Listen_tcp_52b.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-52b.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Listen_tcp Read data using a listening tcp connection
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
class CWE90_LDAP_Injection__Listen_tcp_52b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data )
    {
        CWE90_LDAP_Injection__Listen_tcp_52c.GoodG2BSink(data );
    }
#endif
}
}
