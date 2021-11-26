/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE284_Improper_Access_Control__RegistryKey_02.cs
Label Definition File: CWE284_Improper_Access_Control.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 284 Improper Access Control
* Sinks: RegistryKey
*    GoodSink: Create a registry key without excessive privileges
*    BadSink : Create a registry key with excessive privileges
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Security.AccessControl;
using Microsoft.Win32;

using System.Web;

namespace testcases.CWE284_Improper_Access_Control
{
class CWE284_Improper_Access_Control__RegistryKey_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            /* FLAW: Create a registry key with excessive privileges */
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("CWE314");
        }
    }
#endif //omitbad

}
}
