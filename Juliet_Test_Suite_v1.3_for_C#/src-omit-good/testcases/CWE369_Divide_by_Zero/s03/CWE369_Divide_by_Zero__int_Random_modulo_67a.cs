/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Random_modulo_67a.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Random_modulo_67a : AbstractTestCase
{

    public class Container
    {
        public int containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE369_Divide_by_Zero__int_Random_modulo_67b.BadSink(dataContainer  );
    }
#endif //omitbad

}
}
