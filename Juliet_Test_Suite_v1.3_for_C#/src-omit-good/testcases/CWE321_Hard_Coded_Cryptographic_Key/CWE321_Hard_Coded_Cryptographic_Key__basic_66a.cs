/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE321_Hard_Coded_Cryptographic_Key__basic_66a.cs
Label Definition File: CWE321_Hard_Coded_Cryptographic_Key__basic.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 321 Hard coded crypto key
 * BadSource:  Set data to a hardcoded value
 * GoodSource: Read data from the console using readLine()
 * Sinks:
 *    BadSink : Use data as a cryptographic key
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE321_Hard_Coded_Cryptographic_Key
{

class CWE321_Hard_Coded_Cryptographic_Key__basic_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override  void Bad()
    {
        string data;
        /* FLAW: Set data to a hardcoded value */
        data = "23 ~j;asn!@#/>as";
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE321_Hard_Coded_Cryptographic_Key__basic_66b.BadSink(dataArray  );
    }
#endif //omitbad

}
}
