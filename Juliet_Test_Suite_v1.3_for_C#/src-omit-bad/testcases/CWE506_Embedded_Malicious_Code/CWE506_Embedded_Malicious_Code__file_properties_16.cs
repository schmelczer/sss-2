/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__file_properties_16.cs
Label Definition File: CWE506_Embedded_Malicious_Code.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: file_properties
*    GoodSink: Do not modify any file properties
*    BadSink : Alter file property Last Modified
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__file_properties_16 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() change the conditions on the while statements */
    private void Good1()
    {
        while(true)
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
            break;
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}