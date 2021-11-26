/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE193_Off_by_One_Error__do_12.cs
Label Definition File: CWE193_Off_by_One_Error.label.xml
Template File: point-flaw-12.tmpl.cs
*/
/*
* @description
* CWE: 193 An array index is 1 off from the max array index
* Sinks: do
*    GoodSink: restrict max index value
*    BadSink : access array index outside array max
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE193_Off_by_One_Error
{
class CWE193_Off_by_One_Error__do_12 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.StaticReturnsTrueOrFalse())
        {
            int[] intArray = new int[10];
            int i = 0;
            do
            {
                IO.WriteLine("intArray[" + i + "] = " + (intArray[i] = i));
                i++;
            }
            while (i <= intArray.Length);   /* FLAW: Use <= rather than < */
        }
        else
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
    }
#endif //omitbad

}
}
