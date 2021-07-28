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
    public class FileWorkTests
    {

        private List<ISemitrailer> _semitrailers;
        private List<ITractor> _tractors;

        [SetUp]
        public void Setup()
        {
            var awning = new Awning();
            var cistern = new Cistern();
            var refrigerator = new Refrigerator();

            _semitrailers = new List<ISemitrailer>();

            _semitrailers.Add(awning);
            _semitrailers.Add(cistern);
            _semitrailers.Add(refrigerator);

            var actrosLS = new ActrosLS();
            var DAF = new DAF();

            _tractors = new List<ITractor>();
            _tractors.Add(actrosLS);
            _tractors.Add(DAF);
            
        }

        [Test]
        public void WriteSemitrailerXmlWriter_WhenObjectIsSemitrailer_ShouldWriteAllSemitrailers()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\SemitrailerList.xml";
            FileExtention.WriteSemitrailerXmlWriter(_semitrailers, filePath);

            string textFromFile = File.ReadAllText(filePath);
            textFromFile.Should().NotBeEmpty();
        }

        [Test]
        public void WriteTractorXmlWriter_WhenObjectIsTractor_ShouldWriteAllTractors()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\TractorList.xml";
            FileExtention.WriteTractorXmlWriter(_tractors, filePath);

            string textFromFile = File.ReadAllText(filePath);
            textFromFile.Should().NotBeEmpty();
        }

        [Test]
        public void Test_ReadSemitrailerXmlReader()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\SemitrailerList.xml";
            var semitrailers = FileExtention.ReadSemitrailerXmlReader(filePath);
            semitrailers.Should().NotBeNullOrEmpty();
            semitrailers.Should().BeEquivalentTo(_semitrailers);
        }

        [Test]
        public void Test_ReadTractorXmlReader()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\TractorList.xml";
            var tractors = FileExtention.ReadTractorXmlReader(filePath);
            tractors.Should().NotBeNullOrEmpty();
            tractors.Should().BeEquivalentTo(_tractors);
        }

        [Test]
        public void Test_ReadSimtrailerStreamReader()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\SemitrailerList.xml";
            var semitrailers = FileExtention.ReadSemitrailersStreamReader(filePath);
            semitrailers.Should().NotBeNullOrEmpty();
            semitrailers.Should().BeEquivalentTo(_semitrailers);
        }

        [Test]
        public void Test_ReadTractorStreamReader()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\TractorList.xml";
            var tractors = FileExtention.ReadTractorXmlReader(filePath);
            tractors.Should().NotBeNullOrEmpty();
            tractors.Should().BeEquivalentTo(_tractors);
        }

        [Test]
        public void WriteSemitrailerStreamWriter_WhenObjectIsSemitrailer_ShouldWriteAllSemitrailers()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\SemitrailerList.xml";
            FileExtention.WriteSemitrailerStreamWriter(_semitrailers, filePath);

            string textFromFile = File.ReadAllText(filePath);
            textFromFile.Should().NotBeEmpty();
        }

        [Test]
        public void WriteTractorStreamWriter_WhenObjectIsSemitrailer_ShouldWriteAllSemitrailers()
        {
            var filePath = @"..\..\..\..\Epam_Task_2\Resources\TractorList.xml";
            FileExtention.WriteTractorStreamWriter(_tractors, filePath);

            string textFromFile = File.ReadAllText(filePath);
            textFromFile.Should().NotBeEmpty();
        }
    }
}