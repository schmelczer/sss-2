/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE193_Off_by_One_Error__do_01.cs
Label Definition File: CWE193_Off_by_One_Error.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 193 An array index is 1 off from the max array index
* Sinks: do
*    GoodSink: restrict max index value
*    BadSink : access array index outside array max
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE193_Off_by_One_Error
{
class CWE193_Off_by_One_Error__do_01 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        Good1();
    }

    private void Good1()
    {
        int[] intArray = new int[10];
        int i = 0;
        do
        {
            IO.WriteLine("intArray[" + i + "] = " + (intArray[i] = i));
            i++;
        }
        while (i < intArray.Length);   /* FIX: Use < to ensure no out of bounds access */
    }
#endif //omitgood
}
}
