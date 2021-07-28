using Epam_Task_2;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.IndustryTests
{
    public class TractorTests
    {
        [TestCase("ActrosLS", TestName = "SearchTractorByType_WhenActrosLSIsFound_ShouldReturnTrue")]
        [TestCase("DAF", TestName = "SearchTractorByType_WhenDAFIsFound_ShouldReturnTrue")]
        public void Test_SearchTractorByType(string type)
        {
            // Arrange
            var carPark = new CarPark();
                
            // Act
            var result = carPark.SearchTractorByType(type);

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void SearchTractorByType_WhenTractorIsNotFound_ShouldReturnFalse()
        {
            // Arrange
            var carPark = new CarPark();

            // Act
            var result = carPark.SearchTractorByType("VAZ");

            // Assert
            result.Should().BeFalse();
        }
    }
}