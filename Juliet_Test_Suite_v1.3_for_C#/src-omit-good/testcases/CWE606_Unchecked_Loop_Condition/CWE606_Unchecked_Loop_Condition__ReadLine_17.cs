/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__ReadLine_17.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 606 Unchecked Input for Loop Condition
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: hardcoded int in string form
* Sinks:
*    GoodSink: validate loop variable
*    BadSink : loop variable not validated
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__ReadLine_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        data = ""; /* Initialize data */
        {
            /* read user input from console with ReadLine */
            try
            {
                /* POTENTIAL FLAW: Read data from the console using ReadLine */
                data = Console.ReadLine();
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        for (int j = 0; j < 1; j++)
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
