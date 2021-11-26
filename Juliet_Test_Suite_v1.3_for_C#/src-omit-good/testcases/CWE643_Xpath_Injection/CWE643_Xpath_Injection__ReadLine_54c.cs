/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__ReadLine_54c.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-54c.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.Runtime.InteropServices;
using System.Xml.XPath;

namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__ReadLine_54c
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE643_Xpath_Injection__ReadLine_54d.BadSink(data );
    }
#endif


}
}