/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE379_Temporary_File_Creation_in_Insecure_Dir__basic_16.cs
Label Definition File: CWE379_Temporary_File_Creation_in_Insecure_Dir__basic.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 379 File Creation in Insecure Directory
* Sinks:
*    GoodSink: Restrict permissions on directory
*    BadSink : Permissions never set on directory
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE379_Temporary_File_Creation_in_Insecure_Dir
{
class CWE379_Temporary_File_Creation_in_Insecure_Dir__basic_16 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() change the conditions on the while statements */
    private void Good1()
    {
        while(true)
        {
            string tempPath = Path.GetTempFileName();
            int p = (int)Environment.OSVersion.Platform;
            string directoryName;
            if (p == (int)PlatformID.Win32NT || p == (int)PlatformID.Win32Windows || p == (int)PlatformID.Win32S || p == (int)PlatformID.WinCE)
            {
                /* running on Windows */
                directoryName = ".\\src\\testcases\\CWE379_File_Creation_in_Insecure_Dir\\secureDir";
            }
            else
            {
                /* running on non-Windows */
                directoryName = "/home/user/testcases/CWE379_File_Creation_in_Insecure_Dir/secureDir/";
            }
            try
            {
                /* FIX: Set newDirectory as writable by owner, readable by owner, not executable (if file system supports it) */
                File.SetAttributes(directoryName, FileAttributes.Normal);
                Directory.CreateDirectory(directoryName);
                if (Directory.Exists(directoryName))
                {
                    IO.WriteLine("Directory created");
                    using (StreamWriter sw = new StreamWriter(tempPath))
                    {
                        /* Set file as writable by owner, readable by owner, not executable (if file system supports it) */
                        File.SetAttributes(tempPath, FileAttributes.Normal);
                        /* Write something to the file */
                        sw.Write(42);
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error writing to temporary file", exceptIO);
            }
            finally
            {
                /* Delete the temporary file */
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
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
