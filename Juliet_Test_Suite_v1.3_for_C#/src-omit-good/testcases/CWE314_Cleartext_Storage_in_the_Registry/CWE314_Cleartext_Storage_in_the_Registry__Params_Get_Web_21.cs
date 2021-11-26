/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE314_Cleartext_Storage_in_the_Registry__Params_Get_Web_21.cs
Label Definition File: CWE314_Cleartext_Storage_in_the_Registry.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 314 Cleartext storage in the registry
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in registry
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using Microsoft.Win32;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Web;


namespace testcases.CWE314_Cleartext_Storage_in_the_Registry
{
class CWE314_Cleartext_Storage_in_the_Registry__Params_Get_Web_21 : AbstractTestCaseWeb
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        badPrivate = true;
        BadSink(data , req, resp);
    }

    private void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        if (badPrivate)
        {
            using (SecureString secureData = new SecureString())
            {
                for (int i = 0; i < data.Length; i++)
                {
                    secureData.AppendChar(data[i]);
                }
                /* POTENTIAL FLAW: Store data directly in registry */
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
                key.CreateSubKey("CWEparent");
                key = key.OpenSubKey("CWEparent", true);
                key.CreateSubKey("TestingCWE");
                key = key.OpenSubKey("TestingCWE", true);
                key.SetValue("CWE", secureData);
            }
        }
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;

}
}
