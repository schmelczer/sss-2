/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE328_Reversible_One_Way_Hash__SHA1_06.cs
Label Definition File: CWE328_Reversible_One_Way_Hash.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 328 Reversible One Way Hash
* Sinks: SHA1
*    GoodSink: SHA512
*    BadSink : SHA1
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Text;
using System.Security.Cryptography;

namespace testcases.CWE328_Reversible_One_Way_Hash
{
class CWE328_Reversible_One_Way_Hash__SHA1_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_FIVE == 5)
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