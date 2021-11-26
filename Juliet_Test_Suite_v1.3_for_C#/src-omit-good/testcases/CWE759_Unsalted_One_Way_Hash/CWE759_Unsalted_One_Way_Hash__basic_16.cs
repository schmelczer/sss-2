/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE759_Unsalted_One_Way_Hash__basic_16.cs
Label Definition File: CWE759_Unsalted_One_Way_Hash__basic.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 759 Use of one-way hash with no salt
* Sinks:
*    GoodSink: use a sufficiently random salt
*    BadSink : SHA512 with no salt
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Text;
using System.Security.Cryptography;

namespace testcases.CWE759_Unsalted_One_Way_Hash
{
class CWE759_Unsalted_One_Way_Hash__basic_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        while(true)
        {
            using (HashAlgorithm sha = new SHA512CryptoServiceProvider())
            {
                /* FLAW: SHA512 with no salt */
                byte[] textWithoutSaltBytes = Encoding.UTF8.GetBytes("hash me");
                byte[] hashedBytes = sha.ComputeHash(textWithoutSaltBytes);
                sha.Clear();
                IO.WriteLine(IO.ToHex(hashedBytes));
            }
            break;
        }
    }
#endif //omitbad

}
}
