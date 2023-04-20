
using UserNamespace;

namespace UserTests
{
    public class UserTest
    {
        [Fact]
        public void User_Constructor_CreatesUserObject()
        {
            User userTest = new User("Jeremy", "jeremy@gmail.com");

            Assert.Equal("Jeremy", userTest.Name);
            Assert.Equal("jeremy@gmail.com", userTest.Email);
            Assert.False(userTest.IsLoggedIn);

        }

        [Fact]
        public void User_IsSetupComplete_ChecksAllUserPropertiesAreSet()
        {
            User userTest = new User("Jeremy","email");

            Assert.False(userTest.IsSetupComplete());

            userTest.CreatePassword("email","test");

            Assert.True(userTest.IsSetupComplete());
        }

        [Fact]
        public void User_CreatePassword_UpdatesPassword()
        {
            User userTest = new User("Jeremy", "email");

            userTest.CreatePassword("email","test");

            Assert.True(userTest.IsSetupComplete());
        }

        [Fact]
        public void User_LogIn_ReturnsAndSetsLoggedInBoolToTrue()
        {
            User userTest = new User("Jeremy", "email");
            userTest.CreatePassword("email", "test");

            var stringTest = userTest.LogIn("not test");

            Assert.Equal("Not Logged In", stringTest);

            stringTest = userTest.LogIn("test");

            Assert.True(userTest.IsLoggedIn);
            Assert.Equal("Logged In", stringTest);



        }

        [Fact]
        public void User_LogOut_SetsLoggedInPropertyToFalse()
        {
            User userTest = new User("Jeremy", "email");
            userTest.CreatePassword("email", "test");

            var stringTest = userTest.LogIn("test");

            userTest.LogOut();

            Assert.False(userTest.IsLoggedIn);

        }
    }
}