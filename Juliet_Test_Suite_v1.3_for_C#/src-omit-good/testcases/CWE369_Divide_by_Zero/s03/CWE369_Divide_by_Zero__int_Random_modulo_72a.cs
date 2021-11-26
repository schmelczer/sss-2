/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Random_modulo_72a.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Random_modulo_72a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE369_Divide_by_Zero__int_Random_modulo_72b.BadSink(dataHashtable  );
    }
#endif //omitbad

}
}
