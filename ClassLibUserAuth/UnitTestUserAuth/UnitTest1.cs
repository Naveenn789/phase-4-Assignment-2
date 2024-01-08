using ClassLibUserAuth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestUserAuth;

namespace UnitTestUserAuth
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserAuthenticator auth = new UserAuthenticator();
            string rs = "Registration Sucessfull";
            string ru = "Registration Unsucessfull";
            string uf = "User Found";
            string un = "User Not Found";
            Assert.AreEqual(rs, auth.Registration("Simbu", "Simbhu@123"));
            Assert.AreEqual(ru, auth.Registration("Sam", "sam123"));
            Assert.AreEqual(uf, auth.UserLogin("Priya", "Priya@123"));
            Assert.AreEqual(un, auth.UserLogin("Shyam", "Sham@123"));
        }
    }
}
