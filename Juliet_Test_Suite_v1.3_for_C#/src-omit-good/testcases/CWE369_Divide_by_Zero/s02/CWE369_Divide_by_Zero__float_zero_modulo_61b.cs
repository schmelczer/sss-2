/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_zero_modulo_61b.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: zero Set data to a hardcoded value of zero
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_zero_modulo_61b
{
#if (!OMITBAD)
    public static float BadSource()
    {
        float data;
        data = 0.0f; /* POTENTIAL FLAW: data is set to zero */
        return data;
    }
#endif


}
}
