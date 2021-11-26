/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE284_Improper_Access_Control__RegistryKey_15.cs
Label Definition File: CWE284_Improper_Access_Control.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 284 Improper Access Control
* Sinks: RegistryKey
*    GoodSink: Create a registry key without excessive privileges
*    BadSink : Create a registry key with excessive privileges
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Security.AccessControl;
using Microsoft.Win32;

using System.Web;

namespace testcases.CWE284_Improper_Access_Control
{
class CWE284_Improper_Access_Control__RegistryKey_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        switch (7)
        {
        case 7:
            /* FLAW: Create a registry key with excessive privileges */
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("CWE314");
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
