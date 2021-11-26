/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE328_Reversible_One_Way_Hash__SHA1_08.cs
Label Definition File: CWE328_Reversible_One_Way_Hash.label.xml
Template File: point-flaw-08.tmpl.cs
*/
/*
* @description
* CWE: 328 Reversible One Way Hash
* Sinks: SHA1
*    GoodSink: SHA512
*    BadSink : SHA1
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Text;
using System.Security.Cryptography;

namespace testcases.CWE328_Reversible_One_Way_Hash
{
class CWE328_Reversible_One_Way_Hash__SHA1_08 : AbstractTestCase
{
    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false.
     */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        if (PrivateReturnsTrue())
        {
            using (HashAlgorithm sha1 = new SHA1CryptoServiceProvider())
            {
                /* FLAW: Insecure cryptographic hashing algorithm (SHA1) */
                byte[] textWithUTF8 = Encoding.UTF8.GetBytes("Test Input"); /* INCIDENTAL FLAW: Hard-coded input to hash algorithm */
                byte[] textWithReversibleHash = sha1.ComputeHash(textWithUTF8);
                IO.WriteLine(IO.ToHex(textWithReversibleHash));
            }
        }
    }
#endif //omitbad

}
}
