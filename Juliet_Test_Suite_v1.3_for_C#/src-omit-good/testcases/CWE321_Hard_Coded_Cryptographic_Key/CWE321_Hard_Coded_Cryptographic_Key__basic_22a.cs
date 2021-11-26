/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE321_Hard_Coded_Cryptographic_Key__basic_22a.cs
Label Definition File: CWE321_Hard_Coded_Cryptographic_Key__basic.label.xml
Template File: sources-sink-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 321 Hard coded crypto key
 * BadSource:  Set data to a hardcoded value
 * GoodSource: Read data from the console using readLine()
 * Sinks:
 *    BadSink : Use data as a cryptographic key
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace testcases.CWE321_Hard_Coded_Cryptographic_Key
{
class CWE321_Hard_Coded_Cryptographic_Key__basic_22a : AbstractTestCase
{

    /* The public static variable below is used to drive control flow in the source function.
     * The public static variable mimics a global variable in the C/C++ language family. */
    public static bool badPublicStatic = false;
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        badPublicStatic = true;
        data = CWE321_Hard_Coded_Cryptographic_Key__basic_22b.BadSource();
        if (data != null)
        {
            string stringToEncrypt = "Super secret Squirrel";
            byte[] byteCipherText = null;
            /* POTENTIAL FLAW: Use data as a cryptographic key */
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(Encoding.UTF8.GetBytes(data), aes.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(stringToEncrypt);
                        }
                        byteCipherText = msEncrypt.ToArray();
                    }
                }
            }
            IO.WriteLine(IO.ToHex(byteCipherText)); /* Write encrypted data to console */
        }
    }
#endif //omitbad
    /* The public static variables below are used to drive control flow in the source functions.
     * The public static variable mimics a global variable in the C/C++ language family. */
    public static bool goodG2B1PublicStatic = false;
    public static bool GoodG2B2PublicStatic = false;

}
}
