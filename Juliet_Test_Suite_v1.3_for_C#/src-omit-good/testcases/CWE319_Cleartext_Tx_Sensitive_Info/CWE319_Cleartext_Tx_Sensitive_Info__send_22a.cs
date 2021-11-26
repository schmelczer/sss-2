/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__send_22a.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info__send.label.xml
Template File: sources-sinks-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 319 Cleartext Transmission of Sensitive Information
 * BadSource:  Establish data as a password
 * GoodSource: Use a regular string (non-sensitive string)
 * Sinks:
 *    GoodSink: encrypted_channel
 *    BadSink : unencrypted_channel
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Security;

namespace testcases.CWE319_Cleartext_Tx_Sensitive_Info
{
class CWE319_Cleartext_Tx_Sensitive_Info__send_22a : AbstractTestCase
{

    /* The public static variable below is used to drive control flow in the sink function. */
    public static bool badPublicStatic = false;
#if (!OMITBAD)
    public override void Bad()
    {
        string data = null;
        using (SecureString securePwd = new SecureString())
        {
            for (int i = 0; i < "AP@ssw0rd".Length; i++)
            {
                /* INCIDENTAL: CWE-798 Use of Hard-coded Credentials */
                securePwd.AppendChar("AP@ssw0rd"[i]);
            }
            /* POTENTIAL FLAW: Set data to be a password, which can be transmitted over a non-secure
             * channel in the sink */
            data = securePwd.ToString();
        }
        badPublicStatic = true;
        CWE319_Cleartext_Tx_Sensitive_Info__send_22b.BadSink(data );
    }
#endif //omitbad
    /* The public static variables below are used to drive control flow in the sink functions. */
    public static bool goodB2G1PublicStatic = false;
    public static bool goodB2G2PublicStatic = false;
    public static bool goodG2BPublicStatic = false;

}
}
