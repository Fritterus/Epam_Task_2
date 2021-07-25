using Epam_Task_2.FileWork;
using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;
using Epam_Task_2.Tractors;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Tests.FileWorkTests
{
    public class FileWorkTest
    {

        private List<ISemitrailer> _semitrailers;

        [SetUp]
        public void Setup()
        {
            var awning = new Awning();
            var cistern = new Cistern();
            var refrigerator = new Refrigerator();

            var actrosLS = new ActrosLS();
            var DAF = new DAF();

            _semitrailers = new List<ISemitrailer>();

            _semitrailers.Add(awning);
            _semitrailers.Add(cistern);
            _semitrailers.Add(refrigerator);
        }

        [Test]
        public void Test1()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\SemitrailerList.xml";
            FileExtention.WriteSemitrailerXmlWriter(_semitrailers, filePath);

            string textFromFile = File.ReadAllText(filePath);
            textFromFile.Should().NotBeEmpty();
        }

        [Test]
        public void Test2()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\SemitrailerList.xml";
            var semitrailers = FileExtention.ReadSemitrailerXmlReader(filePath);
            semitrailers.Should().NotBeNullOrEmpty();
            semitrailers.Should().BeEquivalentTo(_semitrailers);
        }
    }
}