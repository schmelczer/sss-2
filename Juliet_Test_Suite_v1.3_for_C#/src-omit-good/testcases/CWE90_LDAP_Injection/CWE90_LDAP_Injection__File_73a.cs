/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__File_73a.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE90_LDAP_Injection
{

class CWE90_LDAP_Injection__File_73a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        data = ""; /* Initialize data */
        {
            try
            {
                /* read string from file into data */
                using (StreamReader sr = new StreamReader("data.txt"))
                {
                    /* POTENTIAL FLAW: Read data from a file */
                    /* This will be reading the first "line" of the file, which
                     * could be very long if there are little or no newlines in the file */
                    data = sr.ReadLine();
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        LinkedList<string> dataLinkedList = new LinkedList<string>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE90_LDAP_Injection__File_73b.BadSink(dataLinkedList  );
    }
#endif //omitbad

}
}