/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Random_modulo_68a.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Random_modulo_68a : AbstractTestCase
{

    public static int data;
#if (!OMITBAD)
    public override void Bad()
    {
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        CWE369_Divide_by_Zero__int_Random_modulo_68b.BadSink();
    }
#endif //omitbad

}
}
