/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__File_12.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-12.tmpl.cs
*/
/*
* @description
* CWE: 427 Uncontrolled Search Path Element
* BadSource: File Read data from file (named data.txt)
* GoodSource: Use a hardcoded path
* BadSink: Environment
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;

using System.IO;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__File_12 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink by changing the "if" so that
     * both branches use the GoodSource */
    private void GoodG2B()
    {
        string data;
        if (IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: Set the path as the "system" path */
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                data = "/bin";
            }
            else
            {
                data = "%SystemRoot%\\system32";
            }
        }
        else
        {
            /* FIX: Set the path as the "system" path */
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                data = "/bin";
            }
            else
            {
                data = "%SystemRoot%\\system32";
            }
        }
        /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
        Environment.SetEnvironmentVariable("PATH", data);
    }

    public override void Good()
    {
        GoodG2B();
    }
#endif //omitgood
}
}