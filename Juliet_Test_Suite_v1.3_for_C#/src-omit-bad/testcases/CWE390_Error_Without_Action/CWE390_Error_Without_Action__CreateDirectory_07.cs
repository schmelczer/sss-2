/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE390_Error_Without_Action__CreateDirectory_07.cs
Label Definition File: CWE390_Error_Without_Action.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 390 Detection of Error Condition Without Action
* Sinks: CreateDirectory
*    GoodSink: Throw Exception if newDirectory cannot be created
*    BadSink : Do nothing if newDirectory cannot be created
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE390_Error_Without_Action
{
class CWE390_Error_Without_Action__CreateDirectory_07 : AbstractTestCase
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
            int p = (int)Environment.OSVersion.Platform;
            string newDirectory = null;
            if (p == (int)PlatformID.Win32NT || p == (int)PlatformID.Win32Windows || p == (int)PlatformID.Win32S || p == (int)PlatformID.WinCE)
            {
                /* running on Windows */
                newDirectory = "C:\\lvl_1\\lvl_2\\lvl_3\\";
            }
            else
            {
                /* running on non-Windows */
                newDirectory = "/home/user/lvl_1/lvl_2/lvl_3/";
            }
            /* FIX: report the CreateDirectory failure and throw a new Exception */
            try
            {
                Directory.CreateDirectory(newDirectory);
            }
            catch (Exception except)
            {
                throw except;
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (privateFive == 5)
        {
            int p = (int)Environment.OSVersion.Platform;
            string newDirectory = null;
            if (p == (int)PlatformID.Win32NT || p == (int)PlatformID.Win32Windows || p == (int)PlatformID.Win32S || p == (int)PlatformID.WinCE)
            {
                /* running on Windows */
                newDirectory = "C:\\lvl_1\\lvl_2\\lvl_3\\";
            }
            else
            {
                /* running on non-Windows */
                newDirectory = "/home/user/lvl_1/lvl_2/lvl_3/";
            }
            /* FIX: report the CreateDirectory failure and throw a new Exception */
            try
            {
                Directory.CreateDirectory(newDirectory);
            }
            catch (Exception except)
            {
                throw except;
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
