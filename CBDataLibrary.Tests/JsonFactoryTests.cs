using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CBDataLibrary;
using CBDataLibrary.DTOs;

namespace CBDataLibrary.Tests
{
    public class JsonFactoryTests
    {

        [Fact]
        public void LoadJson_ShouldLoadJsonFromFile()
        {
            //Arrange

            //Act
            LearnerDTO learners = JsonFactory.LoadJson();

            //Assert
            Assert.NotNull(learners);
        }

    }
}
