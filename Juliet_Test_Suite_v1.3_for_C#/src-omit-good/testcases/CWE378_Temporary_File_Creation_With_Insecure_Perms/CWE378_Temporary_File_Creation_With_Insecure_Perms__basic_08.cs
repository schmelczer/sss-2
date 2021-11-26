/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE378_Temporary_File_Creation_With_Insecure_Perms__basic_08.cs
Label Definition File: CWE378_Temporary_File_Creation_With_Insecure_Perms__basic.label.xml
Template File: point-flaw-08.tmpl.cs
*/
/*
* @description
* CWE: 378 Explicitly set permissions on files
* Sinks:
*    GoodSink: Restrict permissions on file
*    BadSink : Permissions never set on file
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.AccessControl;

namespace testcases.CWE378_Temporary_File_Creation_With_Insecure_Perms
{
class CWE378_Temporary_File_Creation_With_Insecure_Perms__basic_08 : AbstractTestCase
{
    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false.
     */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        if (PrivateReturnsTrue())
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
