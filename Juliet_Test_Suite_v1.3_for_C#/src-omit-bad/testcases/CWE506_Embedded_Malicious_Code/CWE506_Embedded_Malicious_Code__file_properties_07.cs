/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__file_properties_07.cs
Label Definition File: CWE506_Embedded_Malicious_Code.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: file_properties
*    GoodSink: Do not modify any file properties
*    BadSink : Alter file property Last Modified
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__file_properties_07 : AbstractTestCase
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
            StreamWriter streamFileOutput = null;
            try
            {
                String path = "test_good.txt";
                streamFileOutput = new StreamWriter(path);
                streamFileOutput.Write("This is a new line");
                /* FIX: Not altering file properties */
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "File I/O error");
            }
            finally
            {
                try
                {
                    if (streamFileOutput != null)
                    {
                        streamFileOutput.Close();
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing FileOutputStream");
                }
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (privateFive == 5)
        {
            StreamWriter streamFileOutput = null;
            try
            {
                String path = "test_good.txt";
                streamFileOutput = new StreamWriter(path);
                streamFileOutput.Write("This is a new line");
                /* FIX: Not altering file properties */
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "File I/O error");
            }
            finally
            {
                try
                {
                    if (streamFileOutput != null)
                    {
                        streamFileOutput.Close();
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing FileOutputStream");
                }
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
