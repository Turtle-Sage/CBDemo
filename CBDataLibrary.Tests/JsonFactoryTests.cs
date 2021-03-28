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

        [Fact]
        public void JsonSerialize_ShouldSerializeDTOtoJson()
        {
            //Arrange
            OutputDTO output = new OutputDTO { source_id = "999", first_name = "Oscar", last_name = "Moby" };

            //Act
            string Json = JsonFactory.JsonSerialize(output);

            //Assert
            Assert.NotNull(Json);
        }

    }
}
