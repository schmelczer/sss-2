/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Database_81a.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.Data.SqlClient;

namespace testcases.CWE90_LDAP_Injection
{

class CWE90_LDAP_Injection__Database_81a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE90_LDAP_Injection__Database_81_base baseObject = new CWE90_LDAP_Injection__Database_81_goodG2B();
        baseObject.Action(data );
    }
#endif //omitgood
}
}
