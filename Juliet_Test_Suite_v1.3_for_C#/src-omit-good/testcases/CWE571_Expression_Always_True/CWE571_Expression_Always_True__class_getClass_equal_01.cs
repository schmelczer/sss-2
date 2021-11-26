/*
 * @description statement always evaluates to true
 * 
 * */

using System;
using TestCaseSupport;
using System.Security.Cryptography;
using System.Collections;

namespace testcases.CWE571_Expression_Always_True
{
    class CWE571_Expression_Always_True__class_getClass_equal_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            /* FLAW: always evaluates to true */
            Random random = new Random();
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

            if (!(random.GetType() == rngCsp.GetType()))
            {
                IO.WriteLine("always prints");
            }
        }
#endif // OMITBAD



}
}
