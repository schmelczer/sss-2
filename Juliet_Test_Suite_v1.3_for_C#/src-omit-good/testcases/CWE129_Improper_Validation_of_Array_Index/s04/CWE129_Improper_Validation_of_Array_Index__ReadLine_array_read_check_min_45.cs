/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__ReadLine_array_read_check_min_45.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_read_check_min
 *    GoodSink: Read from array after verifying that data is at least 0 and less than array.length
 *    BadSink : Read from array after verifying that data is at least 0 (but not verifying that data less than array.length)
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__ReadLine_array_read_check_min_45 : AbstractTestCase
{

    private int dataBad;
    private int dataGoodG2B;
    private int dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        int data = dataBad;
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

    public override void Bad()
    {
        int data;
        data = int.MinValue; /* Initialize data */
        {
            /* read user input from console with ReadLine */
            try
            {
                /* POTENTIAL FLAW: Read data from the console using ReadLine */
                string stringNumber = Console.ReadLine();
                if (stringNumber != null) // avoid NPD incidental warnings
                {
                    try
                    {
                        data = int.Parse(stringNumber.Trim());
                    }
                    catch(FormatException exceptNumberFormat)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
