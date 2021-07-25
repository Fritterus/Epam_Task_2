using Epam_Task_2.Factories;
using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.IndustryTests
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