/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE327_Use_Broken_Crypto__3DES_03.cs
Label Definition File: CWE327_Use_Broken_Crypto.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 327 Use of Broken or Risky Cryptographic Algorithm
* Sinks: 3DES
*    GoodSink: use AES
*    BadSink : use 3DES
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.Cryptography;

namespace testcases.CWE327_Use_Broken_Crypto
{
class CWE327_Use_Broken_Crypto__3DES_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            const string CIPHER_INPUT = "ABCDEFG123456";
            byte[] encrypted;
            using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
            {
                /* FLAW: Use a weak crypto algorithm, 3DES */
                ICryptoTransform encryptor = tdes.CreateEncryptor(tdes.Key, tdes.IV);
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
