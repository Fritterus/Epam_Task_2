using Epam_Task2.Factories;
using Epam_Task2.Interfaces;
using Epam_Task2.Semitrailers;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.FactoryTests
{
    public class TotbeTests
    {
        [Test]
        public void GetSemitrailerAwning_ShouldReturnCorrectSemitrailer()
        {
            // Arrange
            ITruckingIndustry semitrailerIndustry = new Totbe();
            Awning expected = new Awning();

            // Act
            ISemitrailer result = semitrailerIndustry.GetSemitrailer();

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}