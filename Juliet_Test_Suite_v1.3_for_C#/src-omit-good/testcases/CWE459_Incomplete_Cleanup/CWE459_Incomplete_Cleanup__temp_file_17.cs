/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE459_Incomplete_Cleanup__temp_file_17.cs
Label Definition File: CWE459_Incomplete_Cleanup.label.xml
Template File: point-flaw-17.tmpl.cs
*/
/*
* @description
* CWE: 459 Incomplete Cleanup
* Sinks: temp_file
*    GoodSink: Delete the temporary file on exit
*    BadSink : Don't delete the temporary file
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE459_Incomplete_Cleanup
{
class CWE459_Incomplete_Cleanup__temp_file_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        for(int j = 0; j < 1; j++)
        {
            string tempPath = Path.GetTempFileName();
            try
            {
                using (StreamWriter sw = File.CreateText(tempPath))
                {
                    IO.WriteLine(sw.ToString());
                    /* FLAW: Do not delete the temporary file */
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Could not create temporary file", exceptIO);
            }
        }
    }
#endif //omitbad

}
}
