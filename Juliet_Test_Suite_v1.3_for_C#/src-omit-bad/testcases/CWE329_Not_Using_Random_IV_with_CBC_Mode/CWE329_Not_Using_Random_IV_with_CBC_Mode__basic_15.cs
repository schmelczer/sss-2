/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE329_Not_Using_Random_IV_with_CBC_Mode__basic_15.cs
Label Definition File: CWE329_Not_Using_Random_IV_with_CBC_Mode__basic.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 329 Not using random IV with CBC Mode
* Sinks:
*    GoodSink: use random iv
*    BadSink : use hardcoded iv
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.Cryptography;

namespace testcases.CWE329_Not_Using_Random_IV_with_CBC_Mode
{
class CWE329_Not_Using_Random_IV_with_CBC_Mode__basic_15 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() change the switch to switch(8) */
    private void Good1()
    {
        switch (8)
        {
        case 7:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        default:
            string text = "asdf";
            byte[] byteCipherText = null;
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                int blockSize = aes.BlockSize;
                byte[] initializationVector = new byte[blockSize/8];
                /* FIX: using cryptographically secure pseudo-random number as initialization vector */
                using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
                {
                    provider.GetBytes(initializationVector);
                }
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, initializationVector);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(text);
                        }
                        byteCipherText = msEncrypt.ToArray();
                    }
                }
            }
            IO.WriteLine(IO.ToHex(byteCipherText)); /* Write encrypted data to console */
            break;
        }
    }

    /* Good2() reverses the blocks in the switch  */
    private void Good2()
    {
        switch (7)
        {
        case 7:
            string text = "asdf";
            byte[] byteCipherText = null;
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                int blockSize = aes.BlockSize;
                byte[] initializationVector = new byte[blockSize/8];
                /* FIX: using cryptographically secure pseudo-random number as initialization vector */
                using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
                {
                    provider.GetBytes(initializationVector);
                }
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, initializationVector);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(text);
                        }
                        byteCipherText = msEncrypt.ToArray();
                    }
                }
            }
            IO.WriteLine(IO.ToHex(byteCipherText)); /* Write encrypted data to console */
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
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
