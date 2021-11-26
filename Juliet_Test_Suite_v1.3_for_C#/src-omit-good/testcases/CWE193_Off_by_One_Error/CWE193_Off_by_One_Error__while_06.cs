/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE193_Off_by_One_Error__while_06.cs
Label Definition File: CWE193_Off_by_One_Error.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 193 An array index is 1 off from the max array index
* Sinks: while
*    GoodSink: restrict max index value
*    BadSink : access array index outside array max
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE193_Off_by_One_Error
{
class CWE193_Off_by_One_Error__while_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_FIVE == 5)
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
