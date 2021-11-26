/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE94_Improper_Control_of_Generation_of_Code__File_22a.cs
Label Definition File: CWE94_Improper_Control_of_Generation_of_Code.label.xml
Template File: sources-sinks-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 94 Improper Control of Generation of Code
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: Set data to an integer represented as a string
 * Sinks:
 *    GoodSink: Validate user input prior to compiling
 *    BadSink : Compile sourceCode containing unvalidated user input
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE94_Improper_Control_of_Generation_of_Code
{
class CWE94_Improper_Control_of_Generation_of_Code__File_22a : AbstractTestCase
{

    /* The public static variable below is used to drive control flow in the sink function. */
    public static bool badPublicStatic = false;
#if (!OMITBAD)
    public override void Bad()
    {
        string data = null;
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
        badPublicStatic = true;
        CWE94_Improper_Control_of_Generation_of_Code__File_22b.BadSink(data );
    }
#endif //omitbad
    /* The public static variables below are used to drive control flow in the sink functions. */
    public static bool goodB2G1PublicStatic = false;
    public static bool goodB2G2PublicStatic = false;
    public static bool goodG2BPublicStatic = false;

}
}
