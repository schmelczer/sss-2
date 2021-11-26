/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__ReadLine_16.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-16.tmpl.cs
*/
/*
* @description
* CWE: 427 Uncontrolled Search Path Element
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: Use a hardcoded path
* BadSink: Environment
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;

using System.IO;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__ReadLine_16 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        string data;
        while (true)
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
            break;
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
