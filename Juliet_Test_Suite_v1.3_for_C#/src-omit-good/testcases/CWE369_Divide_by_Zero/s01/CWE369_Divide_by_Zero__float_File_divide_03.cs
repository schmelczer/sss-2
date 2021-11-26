/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_File_divide_03.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-03.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: File Read data from file (named c:\data.txt)
* GoodSource: A hardcoded non-zero number (two)
* Sinks: divide
*    GoodSink: Check for zero before dividing
*    BadSink : Dividing by a value that may be zero
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_File_divide_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        if (5==5)
        {
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0.0f;
        }
        if (5==5)
        {
            /* POTENTIAL FLAW: Possibly divide by zero */
            int result = (int)(100.0 / data);
            IO.WriteLine(result);
        }
    }
#endif //omitbad

}
}
