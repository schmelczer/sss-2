/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE321_Hard_Coded_Cryptographic_Key__basic_81a.cs
Label Definition File: CWE321_Hard_Coded_Cryptographic_Key__basic.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 321 Hard coded crypto key
 * BadSource:  Set data to a hardcoded value
 * GoodSource: Read data from the console using readLine()
 * Sinks:
 *    BadSink : Use data as a cryptographic key
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE321_Hard_Coded_Cryptographic_Key
{

class CWE321_Hard_Coded_Cryptographic_Key__basic_81a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* FLAW: Set data to a hardcoded value */
        data = "23 ~j;asn!@#/>as";
        CWE321_Hard_Coded_Cryptographic_Key__basic_81_base baseObject = new CWE321_Hard_Coded_Cryptographic_Key__basic_81_bad();
        baseObject.Action(data );
    }
#endif //omitbad

}
}
