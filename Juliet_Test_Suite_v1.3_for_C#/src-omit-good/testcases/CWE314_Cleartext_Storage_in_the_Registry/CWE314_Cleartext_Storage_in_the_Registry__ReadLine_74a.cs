/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE314_Cleartext_Storage_in_the_Registry__ReadLine_74a.cs
Label Definition File: CWE314_Cleartext_Storage_in_the_Registry.label.xml
Template File: sources-sinks-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 314 Cleartext storage in the registry
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in registry
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using Microsoft.Win32;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Web;

using System.IO;

namespace testcases.CWE314_Cleartext_Storage_in_the_Registry
{
class CWE314_Cleartext_Storage_in_the_Registry__ReadLine_74a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        data = ""; /* Initialize data */
        {
            /* read user input from console with ReadLine */
            try
            {
                /* POTENTIAL FLAW: Read data from the console using ReadLine */
                data = Console.ReadLine();
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        Dictionary<int,string> dataDictionary = new Dictionary<int,string>();
        dataDictionary.Add(0, data);
        dataDictionary.Add(1, data);
        dataDictionary.Add(2, data);
        CWE314_Cleartext_Storage_in_the_Registry__ReadLine_74b.BadSink(dataDictionary  );
    }
#endif //omitbad

}
}