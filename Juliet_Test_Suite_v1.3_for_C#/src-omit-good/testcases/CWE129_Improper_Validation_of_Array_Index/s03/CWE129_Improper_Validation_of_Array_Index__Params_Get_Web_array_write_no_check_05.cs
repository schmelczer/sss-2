/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_write_no_check_05.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-05.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_write_no_check
*    GoodSink: Write to array after verifying index
*    BadSink : Write to array without any verification of index
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */
using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Params_Get_Web_array_write_no_check_05 : AbstractTestCaseWeb
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        if (privateTrue)
        {
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (privateTrue)
        {
            /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
            int[] array = { 0, 1, 2, 3, 4 };
            /* POTENTIAL FLAW: Attempt to write to array at location data, which may be outside the array bounds */
            array[data] = 42;
            /* Skip reading back data from array since that may be another out of bounds operation */
        }
    }
#endif //omitbad

}
}
