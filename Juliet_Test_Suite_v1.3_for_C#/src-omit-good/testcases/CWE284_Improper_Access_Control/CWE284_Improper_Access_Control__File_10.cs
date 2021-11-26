/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE284_Improper_Access_Control__File_10.cs
Label Definition File: CWE284_Improper_Access_Control.label.xml
Template File: point-flaw-10.tmpl.cs
*/
/*
* @description
* CWE: 284 Improper Access Control
* Sinks: File
*    GoodSink: Create a file without excessive privileges
*    BadSink : Create a file with excessive privileges
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Security.AccessControl;

using System.Web;

namespace testcases.CWE284_Improper_Access_Control
{
class CWE284_Improper_Access_Control__File_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.staticTrue)
        {
            /* FLAW: Create a file with excessive privileges */
            string path = @"C:\Temp\WriteText.txt";
            File.Create(path);
        }
    }
#endif //omitbad

}
}
