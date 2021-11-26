/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__NetworkCredential_10.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-10.tmpl.cs
*/
/*
* @description
* CWE: 259 Hard Coded Password
* BadSource: hardcodedPassword Set data to a hardcoded string
* GoodSource: Read data from the console using readLine()
* BadSink: NetworkCredential data used as password in NetworkCredential()
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Net;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__NetworkCredential_10 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data;
        if (IO.staticTrue)
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
