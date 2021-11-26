/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Random_array_size_16.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: Random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_size
*    GoodSink: data is used to set the size of the array and it must be greater than 0
*    BadSink : data is used to set the size of the array, but it could be set to 0
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Random_array_size_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        while (true)
        {
            /* POTENTIAL FLAW: Set data to a random value */
            data = (new Random()).Next();
            break;
        }
        while (true)
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
            break;
        }
    }
#endif //omitbad

}
}
