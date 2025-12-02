using MyLib;

namespace MyLibTests
{
    public class StringExtensionsTests
    {
        [Test]
        public void IsValidEmailAddressReturnsTrue()
        {
            // GIVEN
            const string validEmail = "kurt.muster@digicomp.ch";

            // WHEN
            bool result = StringExtensions.IsValidEmailAddress(validEmail);

            // THEN
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValidEmailAddressReturnsFalse()
        {
            // GIVEN
            const string validEmail = "kurt.muster@digicomp";

            // WHEN
            bool result = validEmail.IsValidEmailAddress();

            // THEN
            Assert.That(result, Is.False);
        }

    }
}
