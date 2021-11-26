/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__NetworkCredential_06.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-06.tmpl.cs
*/
/*
* @description
* CWE: 259 Hard Coded Password
* BadSource: hardcodedPassword Set data to a hardcoded string
* GoodSource: Read data from the console using readLine()
* BadSink: NetworkCredential data used as password in NetworkCredential()
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Net;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__NetworkCredential_06 : AbstractTestCase
{

    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data;
        if (PRIVATE_CONST_FIVE == 5)
        {
            /* FLAW: Set data to a hardcoded string */
            data = "7e5tc4s3";
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: data used as password in NetworkCredential() */
            NetworkCredential credentials = new NetworkCredential("user", data, "domain");
            IO.WriteLine(credentials.ToString());
        }
    }
#endif //omitbad

}
}
