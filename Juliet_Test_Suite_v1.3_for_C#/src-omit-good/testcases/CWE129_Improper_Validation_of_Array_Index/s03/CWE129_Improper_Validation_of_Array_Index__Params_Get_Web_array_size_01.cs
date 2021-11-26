/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_size_01.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-01.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_size
*    GoodSink: data is used to set the size of the array and it must be greater than 0
*    BadSink : data is used to set the size of the array, but it could be set to 0
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_size_01 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        data = int.MinValue; /* Initialize data */
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get() */
        {
            string stringNumber = req.Params.Get("name");
            try
            {
                data = int.Parse(stringNumber.Trim());
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading data from parameter 'name'");
            }
        }
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
#endif //omitbad

}
}
