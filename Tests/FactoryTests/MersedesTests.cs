using Epam_Task2.Factories;
using Epam_Task2.Interfaces;
using Epam_Task2.Semitrailers;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.FactoryTests
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