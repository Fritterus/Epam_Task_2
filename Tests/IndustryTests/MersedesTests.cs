using Epam_Task_2.Factories;
using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.IndustryTests
{
    public class MersedesTests
    {
        [Test]
        public void GetSemitrailerAwning_ShouldReturnCorrectSemitrailer()
        {
            // Arrange
            ITruckingIndustry semitrailerIndustry = new Mersedes();
            Cistern expected = new Cistern();

            // Act
            ISemitrailer result = semitrailerIndustry.GetSemitrailer();

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}