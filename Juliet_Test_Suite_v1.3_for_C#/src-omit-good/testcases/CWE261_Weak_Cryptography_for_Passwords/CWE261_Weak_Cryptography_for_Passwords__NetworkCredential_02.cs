/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE261_Weak_Cryptography_for_Passwords__NetworkCredential_02.cs
Label Definition File: CWE261_Weak_Cryptography_for_Passwords__NetworkCredential.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 261 Weak Cryptography for Passwords
* Sinks:
*    GoodSink:
*    BadSink :
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Text;
using System.Net;
using System.Security.Cryptography;

namespace testcases.CWE261_Weak_Cryptography_for_Passwords
{
class CWE261_Weak_Cryptography_for_Passwords__NetworkCredential_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            string password = "";
            StreamReader sr;
            /* FLAW: Weak encryption of password and a malicious person may have access to file. */
            sr = new StreamReader("../../../common/weak_password_file.txt");
            password = sr.ReadLine();
            string decPass = Encoding.UTF8.GetString(Convert.FromBase64String(password));
            NetworkCredential netCred = new NetworkCredential("CWE261", decPass, "");
        }
    }
#endif //omitbad

}
}
