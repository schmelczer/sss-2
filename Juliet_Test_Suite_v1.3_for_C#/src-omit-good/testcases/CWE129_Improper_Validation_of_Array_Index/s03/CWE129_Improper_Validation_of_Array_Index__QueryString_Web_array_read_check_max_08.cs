/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__QueryString_Web_array_read_check_max_08.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-08.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_read_check_max
*    GoodSink: Read from array after verifying index is at least 0 and less than array.length
*    BadSink : Read from array after verifying that data less than array.length (but not verifying that data is at least 0)
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__QueryString_Web_array_read_check_max_08 : AbstractTestCaseWeb
{

    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false. */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        if (PrivateReturnsTrue())
        {
            data = int.MinValue; /* initialize data in case id is not in query string */
            /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParam) */
            {
                if (req.QueryString["id"] != null)
                {
                    try
                    {
                        data = int.Parse(req.QueryString["id"]);
                    }
                    catch (FormatException exceptNumberFormat)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading id from query string");
                    }
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (PrivateReturnsTrue())
        {
            /* Need to ensure that the array is of size > 3  and < 101 due to the GoodSource and the large_fixed BadSource */
            int[] array = { 0, 1, 2, 3, 4 };
            /* POTENTIAL FLAW: Verify that data < array.Length, but don't verify that data > 0, so may be attempting to read out of the array bounds */
            if (data < array.Length)
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
