/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE329_Not_Using_Random_IV_with_CBC_Mode__basic_14.cs
Label Definition File: CWE329_Not_Using_Random_IV_with_CBC_Mode__basic.label.xml
Template File: point-flaw-14.tmpl.cs
*/
/*
* @description
* CWE: 329 Not using random IV with CBC Mode
* Sinks:
*    GoodSink: use random iv
*    BadSink : use hardcoded iv
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.Cryptography;

namespace testcases.CWE329_Not_Using_Random_IV_with_CBC_Mode
{
class CWE329_Not_Using_Random_IV_with_CBC_Mode__basic_14 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes IO.staticFive==5 to IO.staticFive!=5 */
    private void Good1()
    {
        if (IO.staticFive != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
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
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (IO.staticFive == 5)
        {
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