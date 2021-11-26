/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__NetworkCredential_74a.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * Sinks: NetworkCredential
 *    BadSink : data used as password in NetworkCredential()
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{
class CWE259_Hard_Coded_Password__NetworkCredential_74a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* FLAW: Set data to a hardcoded string */
        data = "7e5tc4s3";
        Dictionary<int,string> dataDictionary = new Dictionary<int,string>();
        dataDictionary.Add(0, data);
        dataDictionary.Add(1, data);
        dataDictionary.Add(2, data);
        CWE259_Hard_Coded_Password__NetworkCredential_74b.BadSink(dataDictionary  );
    }
#endif //omitbad

}
}
