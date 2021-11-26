/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE395_Catch_NullPointerException__basic_04.cs
Label Definition File: CWE395_Catch_NullPointerException__basic.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 395 Use of NullPointerException Catch to Detect NULL Pointer Dereference
* Sinks:
*    GoodSink: Check for null before taking action
*    BadSink : Catch NullReferenceException to detect null
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE395_Catch_NullPointerException
{
class CWE395_Catch_NullPointerException__basic_04 : AbstractTestCase
{
    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_TRUE)
        {
            String catchingNull = null;
            if (new Random().Next(2) == 1)
            {
                catchingNull = "CWE395";
            }
            try
            {
                /* INCIDENTAL: Possible Null Pointer Dereference (CWE476 / CWE690) */
                if (catchingNull.Equals("CWE395"))
                {
                    IO.WriteLine("catchingNull is CWE395");
                }
            }
            catch (NullReferenceException exceptNullPointer) /* FLAW: Use of catch block to detect null dereferences */
            {
                IO.WriteLine("catchingNull is null");
            }
        }
    }
#endif //omitbad

}
}
