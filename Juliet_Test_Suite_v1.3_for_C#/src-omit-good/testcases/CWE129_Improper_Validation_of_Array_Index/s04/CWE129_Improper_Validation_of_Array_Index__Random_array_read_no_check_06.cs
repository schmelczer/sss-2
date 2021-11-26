/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Random_array_read_no_check_06.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-06.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: Random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_read_no_check
*    GoodSink: Read from array after verifying index
*    BadSink : Read from array without any verification of index
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Random_array_read_no_check_06 : AbstractTestCase
{

    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value. */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        if (PRIVATE_CONST_FIVE==5)
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
        if (PRIVATE_CONST_FIVE==5)
        {
            /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
            int[] array = { 0, 1, 2, 3, 4 };
            /* POTENTIAL FLAW: Attempt to read from array at location data, which may be outside the array bounds */
            IO.WriteLine(array[data]);
        }
    }
#endif //omitbad

}
}
