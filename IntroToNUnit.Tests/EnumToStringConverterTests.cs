using NUnit.Framework;

namespace IntroToNUnit.Tests
{
    public enum TestTypes
    {
        none = 0,
        Testing,
        UnitTesting,
        integrationTesting
    }

    [TestFixture]
    public class EnumToStringConverterTests
    {
        [TestCase(TestTypes.none, "None")]
        [TestCase(TestTypes.Testing, "Testing")]
        [TestCase(TestTypes.UnitTesting, "Unit Testing")]
        [TestCase(TestTypes.integrationTesting, "Integration Testing")]
        public void CanConvertEnumIntoFriendlyString(TestTypes value, string expected)
        {
            // Arrange/Act
            var actual = value.ToFriendlyString();

            // Assert
            Assert.That(actual, Is.Not.Null.And.EqualTo(expected));
        }
    }
}
