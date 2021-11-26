/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Environment_array_size_08.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-08.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_size
*    GoodSink: data is used to set the size of the array and it must be greater than 0
*    BadSink : data is used to set the size of the array, but it could be set to 0
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Environment_array_size_08 : AbstractTestCase
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
    public override void Bad()
    {
        int data;
        if (PrivateReturnsTrue())
        {
            data = int.MinValue; /* Initialize data */
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            {
                string stringNumber = Environment.GetEnvironmentVariable("ADD");
                if (stringNumber != null) // avoid NPD incidental warnings
                {
                    try
                    {
                        data = int.Parse(stringNumber.Trim());
                    }
                    catch (FormatException exceptNumberFormat)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
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
