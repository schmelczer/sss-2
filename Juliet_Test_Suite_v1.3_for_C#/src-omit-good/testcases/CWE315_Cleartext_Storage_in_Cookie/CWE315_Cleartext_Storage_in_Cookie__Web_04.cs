/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE315_Cleartext_Storage_in_Cookie__Web_04.cs
Label Definition File: CWE315_Cleartext_Storage_in_Cookie__Web.label.xml
Template File: sources-sinks-04.tmpl.cs
*/
/*
* @description
* CWE: 315 Cleartext storage of data in a cookie
* BadSource:  Set data to credentials (without hashing or encryption)
* GoodSource: Set data to a hash of credentials
* Sinks:
*    GoodSink: Hash data before storing in cookie
*    BadSink : Store data directly in cookie
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
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
class CWE315_Cleartext_Storage_in_Cookie__Web_04 : AbstractTestCaseWeb
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (PRIVATE_CONST_TRUE)
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
        if (PRIVATE_CONST_TRUE)
        {
            /* NOTE: potential incidental issues with not setting secure or HttpOnly flag */
            /* POTENTIAL FLAW: Store data directly in cookie */
            resp.AppendCookie(new HttpCookie("auth", data));
        }
    }
#endif //omitbad

}
}
