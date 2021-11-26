/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE193_Off_by_One_Error__do_16.cs
Label Definition File: CWE193_Off_by_One_Error.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 193 An array index is 1 off from the max array index
* Sinks: do
*    GoodSink: restrict max index value
*    BadSink : access array index outside array max
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE193_Off_by_One_Error
{
class CWE193_Off_by_One_Error__do_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        while(true)
        {
            int[] intArray = new int[10];
            int i = 0;
            do
            {
                IO.WriteLine("intArray[" + i + "] = " + (intArray[i] = i));
                i++;
            }
            while (i <= intArray.Length);   /* FLAW: Use <= rather than < */
            break;
        }
    }
#endif //omitbad

}
}
