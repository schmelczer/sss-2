/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Get_Cookies_Web_67b.cs
Label Definition File: CWE313_Cleartext_Storage_in_a_File_or_on_Disk.label.xml
Template File: sources-sinks-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 313 Cleartext storage in a File or on Disk
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in a file
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Web;

namespace testcases.CWE313_Cleartext_Storage_in_a_File_or_on_Disk
{
class CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Get_Cookies_Web_67b
{
#if (!OMITBAD)
    public static void BadSink(CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Get_Cookies_Web_67a.Container dataContainer , HttpRequest req, HttpResponse resp)
    {
        string data = dataContainer.containerOne;
        using (SecureString secureData = new SecureString())
        {
            for (int i = 0; i < data.Length; i++)
            {
                secureData.AppendChar(data[i]);
            }
            /* POTENTIAL FLAW: Store data directly in a file */
            File.WriteAllText(@"C:\Users\Public\WriteText.txt", secureData.ToString());
        }
    }
#endif


}
}
