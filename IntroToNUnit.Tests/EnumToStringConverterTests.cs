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
        [Test]
        public void CanConvertEnumIntoMultipleWords()
        {
            // Arrange/Act
            var actual = TestTypes.UnitTesting.ToFriendlyString();

            // Assert
            Assert.That(actual, Is.Not.Null.And.EqualTo("Unit Testing"));
        }

        [Test]
        public void CanConvertEnumIntoMultipleWordsWithFirstWordStartingWithLowerCase()
        {
            // Arrange/Act
            var actual = TestTypes.integrationTesting.ToFriendlyString();

            // Assert
            Assert.That(actual, Is.Not.Null.And.EqualTo("integration Testing"));
        }

        [Test]
        public void CanConvertEnumSingleWord()
        {
            // Arrange/Act
            var actual = TestTypes.Testing.ToFriendlyString();

            // Assert
            Assert.That(actual, Is.Not.Null.And.EqualTo("Testing"));
        }

        [Test]
        public void CanConvertEnumSingleLowercaseWord()
        {
            // Arrange/Act
            var actual = TestTypes.none.ToFriendlyString();

            // Assert
            Assert.That(actual, Is.Not.Null.And.EqualTo("none"));
        }
    }
}
