/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__File_03.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-03.tmpl.cs
*/
/*
* @description
* CWE: 606 Unchecked Input for Loop Condition
* BadSource: File Read data from file (named data.txt)
* GoodSource: hardcoded int in string form
* Sinks:
*    GoodSink: validate loop variable
*    BadSink : loop variable not validated
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__File_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        if (5==5)
        {
            data = ""; /* Initialize data */
            {
                try
                {
                    /* read string from file into data */
                    using (StreamReader sr = new StreamReader("data.txt"))
                    {
                        /* POTENTIAL FLAW: Read data from a file */
                        /* This will be reading the first "line" of the file, which
                         * could be very long if there are little or no newlines in the file */
                        data = sr.ReadLine();
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
            data = null;
        }
        if (5==5)
        {
            int numberOfLoops;
            try
            {
                numberOfLoops = int.Parse(data);
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.WriteLine("Invalid response. Numeric input expected. Assuming 1.");
                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Invalid response. Numeric input expected. Assuming 1.");
                numberOfLoops = 1;
            }
            for (int i = 0; i < numberOfLoops; i++)
            {
                /* POTENTIAL FLAW: user supplied input used for loop counter test */
                IO.WriteLine("hello world");
            }
        }
    }
#endif //omitbad

}
}
