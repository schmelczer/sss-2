/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE511_Logic_Time_Bomb__counter_02.cs
Label Definition File: CWE511_Logic_Time_Bomb.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 511 Logic Time Bomb
* Sinks: counter
*    GoodSink: If counter reaches a certain value, print to the console
*    BadSink : If counter reaches a certain value, launch an executable
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE511_Logic_Time_Bomb
{
class CWE511_Logic_Time_Bomb__counter_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            int count = 0;
            do
            {
                /* FLAW: counter triggered backdoor */
                if (count == 20000)
                {
                    using (Process myProcess = new Process())
                    {
                        myProcess.StartInfo.UseShellExecute = false;
                        myProcess.StartInfo.FileName = "c:\\windows\\system32\\evil.exe";
                        myProcess.Start();
                    }
                }
                count++;
            }
            while (count < int.MaxValue);
        }
    }
#endif //omitbad

}
}
