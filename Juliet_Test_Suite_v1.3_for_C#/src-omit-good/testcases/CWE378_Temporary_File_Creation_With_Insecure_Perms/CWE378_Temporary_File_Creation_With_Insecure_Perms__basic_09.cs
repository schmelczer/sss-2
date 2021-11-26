/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE378_Temporary_File_Creation_With_Insecure_Perms__basic_09.cs
Label Definition File: CWE378_Temporary_File_Creation_With_Insecure_Perms__basic.label.xml
Template File: point-flaw-09.tmpl.cs
*/
/*
* @description
* CWE: 378 Explicitly set permissions on files
* Sinks:
*    GoodSink: Restrict permissions on file
*    BadSink : Permissions never set on file
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.AccessControl;

namespace testcases.CWE378_Temporary_File_Creation_With_Insecure_Perms
{
class CWE378_Temporary_File_Creation_With_Insecure_Perms__basic_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_TRUE)
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
