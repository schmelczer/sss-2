/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE284_Improper_Access_Control__RegistryKey_06.cs
Label Definition File: CWE284_Improper_Access_Control.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 284 Improper Access Control
* Sinks: RegistryKey
*    GoodSink: Create a registry key without excessive privileges
*    BadSink : Create a registry key with excessive privileges
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.Security.AccessControl;
using Microsoft.Win32;

namespace testcases.CWE284_Improper_Access_Control
{
class CWE284_Improper_Access_Control__RegistryKey_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;

#if (!OMITGOOD)
    /* Good1() changes PRIVATE_CONST_FIVE==5 to PRIVATE_CONST_FIVE!=5 */
    private void Good1()
    {
        if (PRIVATE_CONST_FIVE != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: Create a registry key without excessive privileges */
            string user = Environment.UserDomainName + "\\" + Environment.UserName;
            RegistrySecurity rs = new RegistrySecurity();
//Allow the current user to read and delete the key.
            rs.AddAccessRule(new RegistryAccessRule(user,
                                                    RegistryRights.ReadKey | RegistryRights.Delete,
                                                    InheritanceFlags.None,
                                                    PropagationFlags.None,
                                                    AccessControlType.Allow));
//Prevent the current user from writing or changing the permission set of the key
            rs.AddAccessRule(new RegistryAccessRule(user,
                                                    RegistryRights.WriteKey | RegistryRights.ChangePermissions,
                                                    InheritanceFlags.None,
                                                    PropagationFlags.None,
                                                    AccessControlType.Deny));
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("CWE314");
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (PRIVATE_CONST_FIVE == 5)
        {
            /* FIX: Create a registry key without excessive privileges */
            string user = Environment.UserDomainName + "\\" + Environment.UserName;
            RegistrySecurity rs = new RegistrySecurity();
//Allow the current user to read and delete the key.
            rs.AddAccessRule(new RegistryAccessRule(user,
                                                    RegistryRights.ReadKey | RegistryRights.Delete,
                                                    InheritanceFlags.None,
                                                    PropagationFlags.None,
                                                    AccessControlType.Allow));
//Prevent the current user from writing or changing the permission set of the key
            rs.AddAccessRule(new RegistryAccessRule(user,
                                                    RegistryRights.WriteKey | RegistryRights.ChangePermissions,
                                                    InheritanceFlags.None,
                                                    PropagationFlags.None,
                                                    AccessControlType.Deny));
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("CWE314");
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
