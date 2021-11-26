/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE315_Cleartext_Storage_in_Cookie__Web_08.cs
Label Definition File: CWE315_Cleartext_Storage_in_Cookie__Web.label.xml
Template File: sources-sinks-08.tmpl.cs
*/
/*
* @description
* CWE: 315 Cleartext storage of data in a cookie
* BadSource:  Set data to credentials (without hashing or encryption)
* GoodSource: Set data to a hash of credentials
* Sinks:
*    GoodSink: Hash data before storing in cookie
*    BadSink : Store data directly in cookie
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;
using System.Web;

using System.Security;

namespace testcases.CWE315_Cleartext_Storage_in_Cookie
{
class CWE315_Cleartext_Storage_in_Cookie__Web_08 : AbstractTestCaseWeb
{

    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false. */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (PrivateReturnsTrue())
        {
            using (SecureString securePwd = new SecureString())
            {
                using (SecureString secureUser = new SecureString())
                {
                    for (int i = 0; i < "AP@ssw0rd".Length; i++)
                    {
                        /* INCIDENTAL: CWE-798 Use of Hard-coded Credentials */
                        securePwd.AppendChar("AP@ssw0rd"[i]);
                    }
                    for (int i = 0; i < "user".Length; i++)
                    {
                        /* INCIDENTAL: CWE-798 Use of Hard-coded Credentials */
                        securePwd.AppendChar("user"[i]);
                    }
                    /* POTENTIAL FLAW: Set data to credentials (without hashing or encryption) */
                    data = secureUser.ToString() + ":" + securePwd.ToString();
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (PrivateReturnsTrue())
        {
            /* NOTE: potential incidental issues with not setting secure or HttpOnly flag */
            /* POTENTIAL FLAW: Store data directly in cookie */
            resp.AppendCookie(new HttpCookie("auth", data));
        }
    }
#endif //omitbad

}
}
