/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE325_Missing_Required_Cryptographic_Step__CryptoStream_15.cs
Label Definition File: CWE325_Missing_Required_Cryptographic_Step.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 325 Missing Required Cryptographic Step
* Sinks: CryptoStream
*    GoodSink: Include call to swEncrypt.Write(plainText)
*    BadSink : Missing call to swEncrypt.Write(plainText)
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.Cryptography;

namespace testcases.CWE325_Missing_Required_Cryptographic_Step
{
class CWE325_Missing_Required_Cryptographic_Step__CryptoStream_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        switch (7)
        {
        case 7:
            string plainText = "ABCDEFG123456";
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    /* FLAW: Missing required step (using CryptoStream).  This will result in the payload to remain in plaintext form */
                    using (StreamWriter swEncrypt = new StreamWriter(msEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
            IO.WriteLine(IO.ToHex(encrypted));
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
