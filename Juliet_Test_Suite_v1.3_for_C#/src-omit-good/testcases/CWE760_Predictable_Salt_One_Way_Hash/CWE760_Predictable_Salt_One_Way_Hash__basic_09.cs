/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE760_Predictable_Salt_One_Way_Hash__basic_09.cs
Label Definition File: CWE760_Predictable_Salt_One_Way_Hash__basic.label.xml
Template File: point-flaw-09.tmpl.cs
*/
/*
* @description
* CWE: 760 Use of one-way hash with a predictable salt
* Sinks:
*    GoodSink: SHA512 with a sufficiently random salt
*    BadSink : SHA512 with a predictable salt
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Text;
using System.Security.Cryptography;

namespace testcases.CWE760_Predictable_Salt_One_Way_Hash
{
class CWE760_Predictable_Salt_One_Way_Hash__basic_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_TRUE)
        {
            Random random = new Random();
            byte[] hashedBytes;
            using (SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider())
            {
                /* FLAW: SHA512 with a predictable salt */
                byte[] textWithSaltBytes = Encoding.UTF8.GetBytes(string.Concat("hash me", random.Next().ToString()));
                hashedBytes = sha512.ComputeHash(textWithSaltBytes);
            }
            IO.WriteLine(IO.ToHex(hashedBytes));
        }
    }
#endif //omitbad

}
}