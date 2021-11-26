/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_random_divide_74a.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: random Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive)
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_random_divide_74a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        /* POTENTIAL FLAW: Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive) */
        Random rand = new Random();
        data = (float)rand.NextDouble();
        Dictionary<int,float> dataDictionary = new Dictionary<int,float>();
        dataDictionary.Add(0, data);
        dataDictionary.Add(1, data);
        dataDictionary.Add(2, data);
        CWE369_Divide_by_Zero__float_random_divide_74b.BadSink(dataDictionary  );
    }
#endif //omitbad

}
}
