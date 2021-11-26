/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE338_Weak_PRNG__random_02.cs
Label Definition File: CWE338_Weak_PRNG.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 338 Use of Cryptographically Weak PRNG
* Sinks: random
*    GoodSink: stronger PRNG
*    BadSink : weak PRNG
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;

namespace testcases.CWE338_Weak_PRNG
{
class CWE338_Weak_PRNG__random_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            /* FLAW: use a weak PRNG */
            IO.WriteLine("" + new Random().NextDouble());
        }
    }
#endif //omitbad

}
}
