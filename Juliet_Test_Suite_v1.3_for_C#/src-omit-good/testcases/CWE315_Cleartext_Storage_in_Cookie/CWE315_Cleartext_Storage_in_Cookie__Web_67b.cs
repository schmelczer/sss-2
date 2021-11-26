/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE315_Cleartext_Storage_in_Cookie__Web_67b.cs
Label Definition File: CWE315_Cleartext_Storage_in_Cookie__Web.label.xml
Template File: sources-sinks-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 315 Cleartext storage of data in a cookie
 * BadSource:  Set data to credentials (without hashing or encryption)
 * GoodSource: Set data to a hash of credentials
 * Sinks:
 *    GoodSink: Hash data before storing in cookie
 *    BadSink : Store data directly in cookie
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace testcases.CWE315_Cleartext_Storage_in_Cookie
{
class CWE315_Cleartext_Storage_in_Cookie__Web_67b
{
#if (!OMITBAD)
    public static void BadSink(CWE315_Cleartext_Storage_in_Cookie__Web_67a.Container dataContainer , HttpRequest req, HttpResponse resp)
    {
        string data = dataContainer.containerOne;
        /* NOTE: potential incidental issues with not setting secure or HttpOnly flag */
        /* POTENTIAL FLAW: Store data directly in cookie */
        resp.AppendCookie(new HttpCookie("auth", data));
    }
#endif


}
}
