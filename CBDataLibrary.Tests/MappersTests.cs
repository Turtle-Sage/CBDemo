using CBDataLibrary.DTOs;
using CBDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CBDataLibrary.BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using CBDataLibrary.BusinessLogic.Interfaces;

namespace CBDataLibrary.Tests
{    
    public class MappersTests
    {
        [Fact]
        public void LearnerDTOtoLearnerModel_ShouldMapLearnerDTOtoLearnerModel()
        {
            //Arrange
            LearnerDTO dto = new LearnerDTO { LearnerId = 123, LearnerCode = "TestCode", Forename = "Jon", Surname = "Armstrong" };
            LearnerModel model = new LearnerModel();

            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddTransient<IMappers, Mappers>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            IMappers mappers = serviceProvider.GetRequiredService<IMappers>();

            //Act            
            model = mappers.LearnerDTOtoLearnerModel(dto);

            //Assert
            Assert.NotNull(model);
            Assert.Equal(dto.LearnerId, model.LearnerId);
            Assert.Equal(dto.LearnerCode, model.LearnerCode);
            Assert.Equal(dto.Forename, model.Forename);
            Assert.Equal(dto.Surname, model.Surname);

        }

        [Fact]
        public void LearnerModeltoOutputModel_ShouldMapLearnerModeltoOutputModel()
        {
            //Arrange
            LearnerModel learner = new LearnerModel
            {
                LearnerId = 456,
                Forename = "Rosie",
                Surname = "Toll",
                DateOfEntry = "01/01/2021",
                AddressDetails = new List<AddressDetailModel>() { new AddressDetailModel 
                { 
                    Number = "456", Street = "Test Street" , PostCode = "LL34 6NG"} 
                },
                Year = "9"
            };
            OutputModel output = new OutputModel();

            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddTransient<IMappers, Mappers>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            IMappers mappers = serviceProvider.GetRequiredService<IMappers>();

            //Act            
            output = mappers.LearnerModeltoOutputModel(learner);

            //Assert            
            Assert.NotNull(output);
            Assert.Equal(learner.LearnerId.ToString(), output.source_id);
            Assert.Equal(learner.Forename, output.first_name);
            Assert.Equal(learner.Surname, output.last_name);
            Assert.Equal(learner.DateOfEntry, output.start_date);
            Assert.Equal(learner.AddressDetails[0].Number + " " + learner.AddressDetails[0].Street, output.address_line_1);
            Assert.Equal(learner.AddressDetails[0].PostCode, output.postcode);
            Assert.Equal(learner.Year, output.year_code);

        }

        [Fact]
        public void OutputModeltoOutputDTO_ShouldMapOutputModeltoOutputDTO()
        {
            //Arrange
            OutputModel model = new OutputModel { source_id = "789", address_line_1 = "10 Dalton Hill", gender = "M" };
            OutputDTO dto = new OutputDTO();

            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddTransient<IMappers, Mappers>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            IMappers mappers = serviceProvider.GetRequiredService<IMappers>();

            //Act            
            dto = mappers.OutputModeltoOutputDTO(model);

            //Assert
            Assert.NotNull(dto);
            Assert.Equal(model.source_id, dto.source_id);
            Assert.Equal(model.address_line_1, dto.address_line_1);
            Assert.Equal(model.gender, dto.gender);

        }

    }
}
