/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE193_Off_by_One_Error__do_05.cs
Label Definition File: CWE193_Off_by_One_Error.label.xml
Template File: point-flaw-05.tmpl.cs
*/
/*
* @description
* CWE: 193 An array index is 1 off from the max array index
* Sinks: do
*    GoodSink: restrict max index value
*    BadSink : access array index outside array max
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE193_Off_by_One_Error
{
class CWE193_Off_by_One_Error__do_05 : AbstractTestCase
{
    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (privateTrue)
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
    }
#endif //omitbad

}
}
