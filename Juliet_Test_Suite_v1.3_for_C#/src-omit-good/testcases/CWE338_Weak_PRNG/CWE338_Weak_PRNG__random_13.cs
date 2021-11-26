/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE338_Weak_PRNG__random_13.cs
Label Definition File: CWE338_Weak_PRNG.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 338 Use of Cryptographically Weak PRNG
* Sinks: random
*    GoodSink: stronger PRNG
*    BadSink : weak PRNG
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;

namespace testcases.CWE338_Weak_PRNG
{
class CWE338_Weak_PRNG__random_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_FIVE == 5)
        {
            /* FLAW: use a weak PRNG */
            IO.WriteLine("" + new Random().NextDouble());
        }
    }
#endif //omitbad

}
}
