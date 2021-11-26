/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE315_Cleartext_Storage_in_Cookie__Web_68b.cs
Label Definition File: CWE315_Cleartext_Storage_in_Cookie__Web.label.xml
Template File: sources-sinks-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 315 Cleartext storage of data in a cookie
 * BadSource:  Set data to credentials (without hashing or encryption)
 * GoodSource: Set data to a hash of credentials
 * Sinks:
 *    GoodSink: Hash data before storing in cookie
 *    BadSink : Store data directly in cookie
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace testcases.CWE315_Cleartext_Storage_in_Cookie
{
class CWE315_Cleartext_Storage_in_Cookie__Web_68b
{
#if (!OMITBAD)
    public static void BadSink(HttpRequest req, HttpResponse resp)
    {
        string data = CWE315_Cleartext_Storage_in_Cookie__Web_68a.data;
        /* NOTE: potential incidental issues with not setting secure or HttpOnly flag */
        /* POTENTIAL FLAW: Store data directly in cookie */
        resp.AppendCookie(new HttpCookie("auth", data));
    }
#endif


}
}
