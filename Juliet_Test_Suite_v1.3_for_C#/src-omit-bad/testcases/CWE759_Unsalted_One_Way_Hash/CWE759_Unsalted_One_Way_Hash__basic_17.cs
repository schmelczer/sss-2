/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE759_Unsalted_One_Way_Hash__basic_17.cs
Label Definition File: CWE759_Unsalted_One_Way_Hash__basic.label.xml
Template File: point-flaw-17.tmpl.cs
*/
/*
* @description
* CWE: 759 Use of one-way hash with no salt
* Sinks:
*    GoodSink: use a sufficiently random salt
*    BadSink : SHA512 with no salt
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Text;
using System.Security.Cryptography;

namespace testcases.CWE759_Unsalted_One_Way_Hash
{
class CWE759_Unsalted_One_Way_Hash__basic_17 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() use the GoodSinkBody in the for statement */
    private void Good1()
    {
        for(int k = 0; k < 1; k++)
        {
            using (HashAlgorithm sha = new SHA512CryptoServiceProvider())
            {
                /* FIX: Use a sufficiently random salt */
                var salt = new byte[32];
                using (var random = new RNGCryptoServiceProvider())
                {
                    random.GetNonZeroBytes(salt);
                    byte[] textWithSaltBytes = Encoding.UTF8.GetBytes(string.Concat("hash me", salt));
                    byte[] hashedBytes = sha.ComputeHash(textWithSaltBytes);
                    sha.Clear();
                    IO.WriteLine(IO.ToHex(hashedBytes));
                }
            }
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}
