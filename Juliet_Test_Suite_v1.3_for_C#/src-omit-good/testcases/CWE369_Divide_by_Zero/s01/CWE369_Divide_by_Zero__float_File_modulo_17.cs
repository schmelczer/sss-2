/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_File_modulo_17.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: File Read data from file (named c:\data.txt)
* GoodSource: A hardcoded non-zero number (two)
* Sinks: modulo
*    GoodSink: Check for zero before modulo
*    BadSink : Modulo by a value that may be zero
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_File_modulo_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        data = -1.0f; /* Initialize data */
        {
            File.Create("data.txt").Close();
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
        for (int j = 0; j < 1; j++)
        {
            /* POTENTIAL FLAW: Possibly modulo by zero */
            int result = (int)(100.0 % data);
            IO.WriteLine(result);
        }
    }
#endif //omitbad

}
}
