/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE329_Not_Using_Random_IV_with_CBC_Mode__basic_17.cs
Label Definition File: CWE329_Not_Using_Random_IV_with_CBC_Mode__basic.label.xml
Template File: point-flaw-17.tmpl.cs
*/
/*
* @description
* CWE: 329 Not using random IV with CBC Mode
* Sinks:
*    GoodSink: use random iv
*    BadSink : use hardcoded iv
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.Cryptography;

namespace testcases.CWE329_Not_Using_Random_IV_with_CBC_Mode
{
class CWE329_Not_Using_Random_IV_with_CBC_Mode__basic_17 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() use the GoodSinkBody in the for statement */
    private void Good1()
    {
        for(int k = 0; k < 1; k++)
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
    }
#endif //omitgood
}
}
