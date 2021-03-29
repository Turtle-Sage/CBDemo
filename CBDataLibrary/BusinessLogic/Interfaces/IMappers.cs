using System;
using System.Collections.Generic;
using System.Text;
using CBDataLibrary.Models;
using CBDataLibrary.DTOs;

namespace CBDataLibrary.BusinessLogic.Interfaces
{
    public interface IMappers
    {
        LearnerModel LearnerDTOtoLearnerModel(LearnerDTO learnerDto);
        OutputModel LearnerModeltoOutputModel(LearnerModel learnerModel);
        OutputDTO OutputModeltoOutputDTO(OutputModel outputModel);
    }
}
