/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE378_Temporary_File_Creation_With_Insecure_Perms__basic_07.cs
Label Definition File: CWE378_Temporary_File_Creation_With_Insecure_Perms__basic.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 378 Explicitly set permissions on files
* Sinks:
*    GoodSink: Restrict permissions on file
*    BadSink : Permissions never set on file
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.AccessControl;

namespace testcases.CWE378_Temporary_File_Creation_With_Insecure_Perms
{
class CWE378_Temporary_File_Creation_With_Insecure_Perms__basic_07 : AbstractTestCase
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (privateFive == 5)
        {
            string tempPathB = Path.GetTempFileName();
            try
            {
                using (StreamWriter sw = new StreamWriter(tempPathB))
                {
                    /* FLAW: Permissions never set on file */
                    /* Write something to the file */
                    sw.Write(42);
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error writing to temporary file", exceptIO);
            }
            finally
            {
                /* Delete the temporary file */
                if (File.Exists(tempPathB))
                {
                    File.Delete(tempPathB);
                }
            }
        }
    }
#endif //omitbad

}
}
