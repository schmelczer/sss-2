/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE459_Incomplete_Cleanup__temp_file_07.cs
Label Definition File: CWE459_Incomplete_Cleanup.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 459 Incomplete Cleanup
* Sinks: temp_file
*    GoodSink: Delete the temporary file on exit
*    BadSink : Don't delete the temporary file
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE459_Incomplete_Cleanup
{
class CWE459_Incomplete_Cleanup__temp_file_07 : AbstractTestCase
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;

#if (!OMITGOOD)
    /* Good1() changes privateFive==5 to privateFive!=5 */
    private void Good1()
    {
        if (privateFive != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            string tempPath = Path.GetTempFileName();
            try
            {
                using (StreamWriter sw = File.CreateText(tempPath))
                {
                    IO.WriteLine(sw.ToString());
                    /* FIX: Call Delete() so that the file will be deleted */
                    File.Delete(tempPath);
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Could not create temporary file", exceptIO);
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (privateFive == 5)
        {
            string tempPath = Path.GetTempFileName();
            try
            {
                using (StreamWriter sw = File.CreateText(tempPath))
                {
                    IO.WriteLine(sw.ToString());
                    /* FIX: Call Delete() so that the file will be deleted */
                    File.Delete(tempPath);
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Could not create temporary file", exceptIO);
            }
        }
    }

    public override void Good()
    {
        Good1();
        Good2();
    }
#endif //omitgood
}
}
