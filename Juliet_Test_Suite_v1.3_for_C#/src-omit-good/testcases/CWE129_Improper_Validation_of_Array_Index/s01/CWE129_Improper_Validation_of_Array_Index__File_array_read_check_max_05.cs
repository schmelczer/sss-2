/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__File_array_read_check_max_05.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-05.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: File Read data from file (named c:\data.txt)
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_read_check_max
*    GoodSink: Read from array after verifying index is at least 0 and less than array.length
*    BadSink : Read from array after verifying that data less than array.length (but not verifying that data is at least 0)
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */
using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__File_array_read_check_max_05 : AbstractTestCase
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        if (privateTrue)
        {
            data = int.MinValue; /* Initialize data */
            {
                try
                {
                    /* read string from file into data */
                    using (StreamReader sr = new StreamReader("data.txt"))
                    {
                        /* POTENTIAL FLAW: Read data from a file */
                        /* This will be reading the first "line" of the file, which
                         * could be very long if there are little or no newlines in the file */
                        string stringNumber = sr.ReadLine();
                        if (stringNumber != null) /* avoid NPD incidental warnings */
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
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
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
