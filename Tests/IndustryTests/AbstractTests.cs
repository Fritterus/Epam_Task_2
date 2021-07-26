using Epam_Task_2.Factories;
using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.IndustryTests
{
    public class AbstractTests
    {
        [TestCaseSource(nameof(TestCases))]
        public void GetSemitrailer_WhenAllCorrect_ShouldReturnAbstractSemitrailer(
            string type,
            string wheelFormula,
            double currentCapacity,
            double maxCapacity,
            double bodyVolume,
            string dischargeDirection,
            double fifthWheelHeight,
            double bodyLength)
        {
            // Arrange
            ITruckingIndustry truckingIndustry = new Abstract(
                type,
                wheelFormula,
                currentCapacity,
                maxCapacity,
                bodyVolume,
                dischargeDirection,
                fifthWheelHeight,
                bodyLength);

            AbstractSemitrailer expected = new AbstractSemitrailer(
                type,
                wheelFormula,
                currentCapacity,
                maxCapacity,
                bodyVolume,
                dischargeDirection,
                fifthWheelHeight,
                bodyLength);

            // Act
            ISemitrailer result = truckingIndustry.GetSemitrailer();

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[] { "AllMetal", "6x4", 7, 44.9, 37, "Front", 1.64, 9.2 },
            new object[] { "Airborne", "6x4-2", 5, 43.7, 35, "Back", 1.59, 9.1 },
            new object[] { "Platform", "4x4", 12, 47.4, 41, "Front", 1.72, 9.6 },
            new object[] { "TimberCarrier", "6x6", 14, 49.1, 43, "Front", 1.75, 9.8 },
            new object[] { "AutoCarrier", "6x6-2", 9, 45.2, 39, "Back", 1.67, 9.3 }
        };
    }
}