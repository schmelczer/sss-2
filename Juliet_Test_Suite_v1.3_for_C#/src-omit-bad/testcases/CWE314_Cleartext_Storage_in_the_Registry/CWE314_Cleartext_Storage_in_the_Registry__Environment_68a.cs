/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE314_Cleartext_Storage_in_the_Registry__Environment_68a.cs
Label Definition File: CWE314_Cleartext_Storage_in_the_Registry.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 314 Cleartext storage in the registry
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in registry
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using Microsoft.Win32;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace testcases.CWE314_Cleartext_Storage_in_the_Registry
{
class CWE314_Cleartext_Storage_in_the_Registry__Environment_68a : AbstractTestCase
{

    public static string data;

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE314_Cleartext_Storage_in_the_Registry__Environment_68b.GoodG2BSink();
    }

    /* goodB2G() - use badsource and goodsink */
    private static void GoodB2G()
    {
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        data = Environment.GetEnvironmentVariable("ADD");
        CWE314_Cleartext_Storage_in_the_Registry__Environment_68b.GoodB2GSink();
    }
#endif //omitgood
}
}
