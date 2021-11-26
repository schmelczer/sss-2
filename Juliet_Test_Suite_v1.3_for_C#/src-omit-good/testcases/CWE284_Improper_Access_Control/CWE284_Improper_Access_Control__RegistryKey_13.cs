/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE284_Improper_Access_Control__RegistryKey_13.cs
Label Definition File: CWE284_Improper_Access_Control.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 284 Improper Access Control
* Sinks: RegistryKey
*    GoodSink: Create a registry key without excessive privileges
*    BadSink : Create a registry key with excessive privileges
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Security.AccessControl;
using Microsoft.Win32;

using System.Web;

namespace testcases.CWE284_Improper_Access_Control
{
class CWE284_Improper_Access_Control__RegistryKey_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_FIVE == 5)
        {
            /* FLAW: Create a registry key with excessive privileges */
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("CWE314");
        }
    }
#endif //omitbad

}
}
