/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE759_Unsalted_One_Way_Hash__basic_02.cs
Label Definition File: CWE759_Unsalted_One_Way_Hash__basic.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 759 Use of one-way hash with no salt
* Sinks:
*    GoodSink: use a sufficiently random salt
*    BadSink : SHA512 with no salt
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Text;
using System.Security.Cryptography;

namespace testcases.CWE759_Unsalted_One_Way_Hash
{
class CWE759_Unsalted_One_Way_Hash__basic_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            using (HashAlgorithm sha = new SHA512CryptoServiceProvider())
            {
                /* FLAW: SHA512 with no salt */
                byte[] textWithoutSaltBytes = Encoding.UTF8.GetBytes("hash me");
                byte[] hashedBytes = sha.ComputeHash(textWithoutSaltBytes);
                sha.Clear();
                IO.WriteLine(IO.ToHex(hashedBytes));
            }
        }
    }
#endif //omitbad

}
}
