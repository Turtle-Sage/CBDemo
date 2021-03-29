using AutoMapper;
using CBDataLibrary.BusinessLogic.Interfaces;
using CBDataLibrary.DTOs;
using CBDataLibrary.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace CBDataLibrary.BusinessLogic
{    
    public class Learner : ILearner
    {
        private readonly IMappers mappers;

        public Learner(IMappers mappers)
        {
            this.mappers = mappers;
        }

        /// <summary>
        /// Gets Json from Resources and Transforms it into the Output format
        /// </summary>
        /// <returns>string</returns>
        public string GetLearner()
        {
            LearnerDTO learnerDTO = JsonFactory.LoadJson();
            LearnerModel learnerModel = mappers.LearnerDTOtoLearnerModel(learnerDTO);
            OutputModel outputModel = mappers.LearnerModeltoOutputModel(learnerModel);            
            OutputDTO outputDTO = mappers.OutputModeltoOutputDTO(outputModel);

            return JsonFactory.JsonSerialize(outputDTO);
        }
    }

    
}
