/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__large_fixed_array_size_02.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: large_fixed Set data to a value greater than the size of the array
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_size
*    GoodSink: data is used to set the size of the array and it must be greater than 0
*    BadSink : data is used to set the size of the array, but it could be set to 0
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__large_fixed_array_size_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        if (true)
        {
            /* POTENTIAL FLAW: Set data to a value greater than the size of the array */
            data = 100;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (true)
        {
            int[] array = null;
            /* POTENTIAL FLAW: Verify that data is non-negative, but still allow it to be 0 */
            if (data >= 0)
            {
                array = new int[data];
            }
            else
            {
                IO.WriteLine("Array size is negative");
            }
            /* do something with the array */
            array[0] = 5;
            IO.WriteLine(array[0]);
        }
    }
#endif //omitbad

}
}
