/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Connect_tcp_74b.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;

using System.DirectoryServices;

namespace testcases.CWE90_LDAP_Injection
{
class CWE90_LDAP_Injection__Connect_tcp_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,string> dataDictionary )
    {
        string data = dataDictionary[2];
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
#endif


}
}
