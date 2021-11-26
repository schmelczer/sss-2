/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Environment_13.cs
Label Definition File: CWE313_Cleartext_Storage_in_a_File_or_on_Disk.label.xml
Template File: sources-sinks-13.tmpl.cs
*/
/*
* @description
* CWE: 313 Cleartext storage in a File or on Disk
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded string
* Sinks:
*    GoodSink: Hash data before storing in registry
*    BadSink : Store data directly in a file
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
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
class CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Environment_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        if (IO.STATIC_READONLY_FIVE==5)
        {
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            data = Environment.GetEnvironmentVariable("ADD");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (IO.STATIC_READONLY_FIVE==5)
        {
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
    }
#endif //omitbad

}
}
