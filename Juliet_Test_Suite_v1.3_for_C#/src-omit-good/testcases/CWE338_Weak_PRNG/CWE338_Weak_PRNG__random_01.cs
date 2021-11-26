/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE338_Weak_PRNG__random_01.cs
Label Definition File: CWE338_Weak_PRNG.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 338 Use of Cryptographically Weak PRNG
* Sinks: random
*    GoodSink: stronger PRNG
*    BadSink : weak PRNG
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;

namespace testcases.CWE338_Weak_PRNG
{
class CWE338_Weak_PRNG__random_01 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        /* FLAW: use a weak PRNG */
        IO.WriteLine("" + new Random().NextDouble());
    }
#endif //omitbad

}
}
