/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Listen_tcp_67a.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE90_LDAP_Injection
{

class CWE90_LDAP_Injection__Listen_tcp_67a : AbstractTestCase
{

    public class Container
    {
        public string containerOne;
    }

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE90_LDAP_Injection__Listen_tcp_67b.GoodG2BSink(dataContainer  );
    }
#endif //omitgood
}
}
