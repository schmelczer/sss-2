/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE327_Use_Broken_Crypto__DES_13.cs
Label Definition File: CWE327_Use_Broken_Crypto.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 327 Use of Broken or Risky Cryptographic Algorithm
* Sinks: DES
*    GoodSink: use AES
*    BadSink : use DES
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.Cryptography;

namespace testcases.CWE327_Use_Broken_Crypto
{
class CWE327_Use_Broken_Crypto__DES_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_FIVE == 5)
        {
            const string CIPHER_INPUT = "ABCDEFG123456";
            byte[] encrypted;
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                /* FLAW: Use a weak crypto algorithm, DES */
                ICryptoTransform encryptor = des.CreateEncryptor(des.Key, des.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(CIPHER_INPUT);
                        }
                        encrypted = ms.ToArray();
                    }
                }
            }
            string encPhrase = System.Text.Encoding.UTF8.GetString(encrypted);
            IO.WriteLine(IO.ToHex(encrypted));
        }
    }
#endif //omitbad

}
}
