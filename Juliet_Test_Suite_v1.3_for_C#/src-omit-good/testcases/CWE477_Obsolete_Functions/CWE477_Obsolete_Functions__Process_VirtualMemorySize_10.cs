/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE477_Obsolete_Functions__Process_VirtualMemorySize_10.cs
Label Definition File: CWE477_Obsolete_Functions.label.xml
Template File: point-flaw-10.tmpl.cs
*/
/*
* @description
* CWE: 477 Use of Obsolete Functions
* Sinks: Process_VirtualMemorySize
*    GoodSink: Use of preferred System.Diagnostics.Process.VirtualMemorySize64
*    BadSink : Use of deprecated System.Diagnostics.Process.VirtualMemorySize
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE477_Obsolete_Functions
{
class CWE477_Obsolete_Functions__Process_VirtualMemorySize_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.staticTrue)
        {
            /* FLAW: Use of deprecated Process.VirtualMemorySize method */
            using (Process myProcess = new Process())
            {
                int vms = myProcess.VirtualMemorySize;
            }
        }
    }
#endif //omitbad

}
}
