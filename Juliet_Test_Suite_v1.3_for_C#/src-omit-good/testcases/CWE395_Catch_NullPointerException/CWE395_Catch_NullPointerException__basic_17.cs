/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE395_Catch_NullPointerException__basic_17.cs
Label Definition File: CWE395_Catch_NullPointerException__basic.label.xml
Template File: point-flaw-17.tmpl.cs
*/
/*
* @description
* CWE: 395 Use of NullPointerException Catch to Detect NULL Pointer Dereference
* Sinks:
*    GoodSink: Check for null before taking action
*    BadSink : Catch NullReferenceException to detect null
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE395_Catch_NullPointerException
{
class CWE395_Catch_NullPointerException__basic_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        for(int j = 0; j < 1; j++)
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
