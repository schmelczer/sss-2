/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Random_array_read_check_min_02.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: Random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_read_check_min
*    GoodSink: Read from array after verifying that data is at least 0 and less than array.length
*    BadSink : Read from array after verifying that data is at least 0 (but not verifying that data less than array.length)
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Random_array_read_check_min_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        if (true)
        {
            /* POTENTIAL FLAW: Set data to a random value */
            data = (new Random()).Next();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (true)
        {
            /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
            int[] array = { 0, 1, 2, 3, 4 };
            /* POTENTIAL FLAW: Verify that data >= 0, but don't verify that data < array.Length, so may be attempting to read out of the array bounds */
            if (data >= 0)
            {
                IO.WriteLine(array[data]);
            }
            else
            {
                IO.WriteLine("Array index out of bounds");
            }
        }
    }
#endif //omitbad

}
}