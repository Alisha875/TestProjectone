using SignInLib;

namespace TestProjectOne
{
    [TestClass]
    public class SignInTest
    {
        [TestMethod]
        public void SuccessMethod()
        {
            string expResult = "valid user";

            Assert.AreEqual(expResult, SignIn.Authenticate("sam", "sam@1256"));
        }
        [TestMethod]
        public void FailMethod()
        {
            string expResult = "invalid user crenditial";

            Assert.AreEqual(expResult, SignIn.Authenticate("ravi", "raj@124"));
        }
        [TestMethod]
        public void AnnonymousMethod()
        {
            string expResult = "You must provide username and password";

            Assert.AreEqual(expResult, SignIn.Authenticate(null, null));
        }
    }
}