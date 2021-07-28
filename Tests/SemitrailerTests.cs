using Epam_Task_2;
using Epam_Task_2.Products.ChemicalProducts;
using Epam_Task_2.Products.Fuels;
using Epam_Task_2.Semitrailers;
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

        [Test]
        public void AddProduct_WhenCanAddProduct_ShouldReturnCorrectCapacity()
        {
            // Arrange
            var awning = new Awning();
            var soap = new Soap();
            awning.AddProduct(soap);
            var expected = soap.Quantity * soap.WeightPerUnit;

            // Act
            var result = awning.GetCurrentCapacity();

            // Assert
            result.Should().Equals(expected);
        }

        [Test]
        public void AddProduct_WhenCanNotAddProduct_ShouldReturnException()
        {
            // Arrange
            var cistern = new Cistern();
            var diesel = new Diesel();

            // Act
            Action result = () => cistern.AddProduct(diesel);

            // Assert
            result.Should().Throw<Exception>().WithMessage("Impossible to add product");
        }

        [Test]
        public void AddProduct_WhenProductIsNotSuitable_ShouldReturnException()
        {
            // Arrange
            var refrigerator = new Refrigerator();
            var gasoline = new Gasoline();

            // Act
            Action result = () => refrigerator.AddProduct(gasoline);

            // Assert
            result.Should().Throw<Exception>().WithMessage("This product is not suitable");
        }
    }
}