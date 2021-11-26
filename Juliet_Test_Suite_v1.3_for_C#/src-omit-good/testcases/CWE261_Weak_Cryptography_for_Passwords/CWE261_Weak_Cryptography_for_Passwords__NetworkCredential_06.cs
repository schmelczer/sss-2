/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE261_Weak_Cryptography_for_Passwords__NetworkCredential_06.cs
Label Definition File: CWE261_Weak_Cryptography_for_Passwords__NetworkCredential.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 261 Weak Cryptography for Passwords
* Sinks:
*    GoodSink:
*    BadSink :
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
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
class CWE261_Weak_Cryptography_for_Passwords__NetworkCredential_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_FIVE == 5)
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
