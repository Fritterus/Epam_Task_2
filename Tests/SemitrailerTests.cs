using Epam_Task_2;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.IndustryTests
{
    public class SemitrailerTests
    {
        [TestCase("Awning", TestName = "SearchSemitrailerByType_WhenAwningIsFound_ShouldReturnTrue")]
        [TestCase("Cistern", TestName = "SearchSemitrailerByType_WhenCisternIsFound_ShouldReturnTrue")]
        [TestCase("Refrigerator", TestName = "SearchSemitrailerByType_WhenRefrigeratorIsFound_ShouldReturnTrue")]
        public void Test_SearchSemitrailerByType(string type)
        {
            // Arrange
            var carPark = new CarPark();
                
            // Act
            var result = carPark.SearchSemitrailerByType(type);

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void SearchSemitrailerByType_WhenGarbageTruckIsNotFound_ShouldReturnFalse()
        {
            // Arrange
            var carPark = new CarPark();
            
            // Act
            var result = carPark.SearchSemitrailerByType("GarbageTruck");

            // Assert
            result.Should().BeFalse();
        }
    }
}