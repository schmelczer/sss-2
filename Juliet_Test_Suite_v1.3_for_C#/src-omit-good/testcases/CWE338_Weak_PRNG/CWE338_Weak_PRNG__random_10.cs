/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE338_Weak_PRNG__random_10.cs
Label Definition File: CWE338_Weak_PRNG.label.xml
Template File: point-flaw-10.tmpl.cs
*/
/*
* @description
* CWE: 338 Use of Cryptographically Weak PRNG
* Sinks: random
*    GoodSink: stronger PRNG
*    BadSink : weak PRNG
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;

namespace testcases.CWE338_Weak_PRNG
{
class CWE338_Weak_PRNG__random_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.staticTrue)
        {
            /* FLAW: use a weak PRNG */
            IO.WriteLine("" + new Random().NextDouble());
        }
    }
#endif //omitbad

}
}
