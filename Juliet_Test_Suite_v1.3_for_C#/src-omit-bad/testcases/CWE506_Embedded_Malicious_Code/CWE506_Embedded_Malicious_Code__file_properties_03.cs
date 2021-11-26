/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__file_properties_03.cs
Label Definition File: CWE506_Embedded_Malicious_Code.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: file_properties
*    GoodSink: Do not modify any file properties
*    BadSink : Alter file property Last Modified
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__file_properties_03 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes 5==5 to 5!=5 */
    private void Good1()
    {
        if (5 != 5)
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
        if (5 == 5)
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
