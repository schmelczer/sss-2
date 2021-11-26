/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Environment_22b.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Environment Read data from an environment variable
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

class CWE90_LDAP_Injection__Environment_22b
{
#if (!OMITBAD)
    public static string BadSource()
    {
        string data;
        if (CWE90_LDAP_Injection__Environment_22a.badPublicStatic)
        {
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            data = Environment.GetEnvironmentVariable("ADD");
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
