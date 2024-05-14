using EmailUnitTests;

namespace EmailValidatorTests
{
    [TestClass]
    public class EmailValidatorTest : EmailTestBase
    {
        [TestMethod]
        public void empty_Invalid_Email()
        {

            TestContext.WriteLine(TestContext.TestName);
           string email = GetTestSetting<string>("emailempty", " ");
            //  string email = TestContext.Properties["emailvalid"].ToString());
            //bool isValid =EmailValidator.IsValidEmail(email);
            // Assert.IsTrue(isValid);
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        }


       [TestMethod]

       public void space_Invalid_Email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("spaceemail", "joe j@gmail.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        }

       

        [TestMethod]

        public void no_atsymbol_InvalidEmail()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("noatsymbolemail", "example.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        }
        [TestMethod]

        public void nodot_InvalidEmail()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("nodotemail", "example2!@gmailcom");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        }

        [TestMethod]

        public void atsign_beforedot_InvalidEmail()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("@before.email", "alber.to@gmail");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        }

        [TestMethod]

        public void nodomainemail()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("nousernameemail", "@gmail.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        }

        [TestMethod]

        public void over100char_username_invalidemail()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("over100charusername", "superduperlongusernamesuperduperlongusernamesuperduperlonguserna!esuperduperlongusernamesuperduperlonguser@gmail.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        }

        [TestMethod]

        public void over100char_domain_invalidemail()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("over100chardomain", "superduperlongdomain@gmail.superduperlongdomainsuperduperlongdomainsuperduperlongdomainsuperduperlongsuperduperlongdomainlongdomain");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        

        }
        [TestMethod]

        public void contains_invalidchar_email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("hasinvalidcharemail", "hey/@gmail.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

       

        }
        [TestMethod]

        public void less_than3_domain()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("lessthan3domain", "john@gmail.co");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        }
        [TestMethod]

        public void nonalpha_atend_email()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("Containsnonalphaatendemail", "john@gmail.com*");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(isInvalid);

        }

        [TestMethod]

        public void valid_email_one()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("validemail1", "j@gmail.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);

        }

        [TestMethod]

        public void valid_email_two()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("validemail2", "jjoes-+@jp.coo");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);

        }
        [TestMethod]

        public void valid_email_three()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("validemail3", "super&amp;wierd^email@.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);

        }
        [TestMethod]
        public void valid_email_four()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("validemail4", "s~!$%^&*_=+}{\\'?-.@jo.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);

            

        }

        [TestMethod]
        public void valid_email_five()
        {
           string email = GetTestSetting<string>("validemail5", "example.1@gmail.pmm");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);
           

        }
        [TestMethod]
        public void valid_email_six()
        {
            string email = GetTestSetting<string>("validemail6", "verylongusername@hotmail.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);



        }
        [TestMethod]
        public void valid_email_seven()
        {
            string email = GetTestSetting<string>("validemail7", "j0hn%5@short.com");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);



        }
        [TestMethod]
        public void valid_email_eight()
        {
            string email = GetTestSetting<string>("validemail8", "DoeJ$89@g.hey");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);



        }

        [TestMethod]
        public void valid_email_nine()
        {
            string email = GetTestSetting<string>("validemail9", "q2w@xp@wed.net");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);



        }
        [TestMethod]

        public void valid_email_ten()
        {
            string email = GetTestSetting<string>("validemail10", "h-e~Y@hey.hey");
            bool isInvalid = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(isInvalid);



        }
    }
}