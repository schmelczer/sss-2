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

#if (!OMITGOOD)
    /* Good1() changes 5==5 to 5!=5 */
    private void Good1()
    {
        if (5 != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            const string CIPHER_INPUT = "ABCDEFG123456";
            byte[] encrypted;
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                /* FIX: Use a stronger crypto algorithm, AES */
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
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

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (5 == 5)
        {
            const string CIPHER_INPUT = "ABCDEFG123456";
            byte[] encrypted;
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                /* FIX: Use a stronger crypto algorithm, AES */
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
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

    public override void Good()
    {
        Good1();
        Good2();
    }
#endif //omitgood
}
}
