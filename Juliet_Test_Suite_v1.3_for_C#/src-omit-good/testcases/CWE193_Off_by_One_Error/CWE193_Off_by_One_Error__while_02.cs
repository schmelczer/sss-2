/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE193_Off_by_One_Error__while_02.cs
Label Definition File: CWE193_Off_by_One_Error.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 193 An array index is 1 off from the max array index
* Sinks: while
*    GoodSink: restrict max index value
*    BadSink : access array index outside array max
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE193_Off_by_One_Error
{
class CWE193_Off_by_One_Error__while_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            int[] intArray = new int[10];
            int i = 0;
            /* FLAW: Use <= rather than < */
            while (i <= intArray.Length)
            {
                IO.WriteLine("intArray[" + i + "] = " + (intArray[i] = i));
                i++;
            }
        }
    }
#endif //omitbad

}
}
