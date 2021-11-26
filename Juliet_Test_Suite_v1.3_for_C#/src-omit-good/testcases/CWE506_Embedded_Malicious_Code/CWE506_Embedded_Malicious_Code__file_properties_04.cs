/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__file_properties_04.cs
Label Definition File: CWE506_Embedded_Malicious_Code.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: file_properties
*    GoodSink: Do not modify any file properties
*    BadSink : Alter file property Last Modified
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__file_properties_04 : AbstractTestCase
{
    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_TRUE)
        {
            StreamWriter streamFileOutput = null;
            String path = "test_bad.txt";
            DateTime lastModified = File.GetLastWriteTime(path);
            try
            {
                streamFileOutput = new StreamWriter(path);
                streamFileOutput.Write("This is a new line");
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
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing StreamWriter");
                }
            }
            try
            {
                /* INCIDENTAL: CWE 252 - Unchecked Return Value - some tools report
                 * an unchecked return value from setLastModified, but this is intentional as
                 * this method call is supposed to be "hidden" in the code
                 */
                /* FLAW: altering file properties */
                File.SetLastWriteTime(path, lastModified.AddSeconds(3600.00));
            }
            catch (FileNotFoundException exceptFile)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptFile, "Accessing File Error");
            }
        }
    }
#endif //omitbad

}
}
