/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE325_Missing_Required_Cryptographic_Step__CryptoStream_02.cs
Label Definition File: CWE325_Missing_Required_Cryptographic_Step.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 325 Missing Required Cryptographic Step
* Sinks: CryptoStream
*    GoodSink: Include call to swEncrypt.Write(plainText)
*    BadSink : Missing call to swEncrypt.Write(plainText)
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.Cryptography;

namespace testcases.CWE325_Missing_Required_Cryptographic_Step
{
class CWE325_Missing_Required_Cryptographic_Step__CryptoStream_02 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes true to false */
    private void Good1()
    {
        if (false)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            string plainText = "ABCDEFG123456";
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    /* FIX: Include required step (using CryptoStream) */
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            IO.WriteLine(IO.ToHex(encrypted));
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (true)
        {
            string plainText = "ABCDEFG123456";
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    /* FIX: Include required step (using CryptoStream) */
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
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
