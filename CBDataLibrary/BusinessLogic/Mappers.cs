using CBDataLibrary.DTOs;
using CBDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CBDataLibrary.BusinessLogic
{
    public interface IMappers
    {
        LearnerModel LearnerDTOtoLearnerModel(LearnerDTO learnerDto);
        OutputModel LearnerModeltoOutputModel(LearnerModel learnerModel);
        OutputDTO OutputModeltoOutputDTO(OutputModel outputModel);
    }

    public class Mappers : IMappers
    {
        private readonly IMapper _mapper;

        public Mappers(IMapper mapper)
        {
            _mapper = mapper;            
        }

        public LearnerModel LearnerDTOtoLearnerModel(LearnerDTO learnerDto)
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<LearnerDTO, LearnerModel>());
            //var mapper = config.CreateMapper();

            LearnerModel model = _mapper.Map<LearnerModel>(learnerDto);

            return model;
        }

        public OutputModel LearnerModeltoOutputModel(LearnerModel learnerModel)
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<LearnerModel, OutputModel>()
            //.ForMember(dest => dest.source_id, opt => opt.MapFrom(src => src.LearnerId.ToString()))
            //.ForMember(dest => dest.pupil_admission_number, opt => opt.MapFrom(src => src.LearnerCode))
            //.ForMember(dest => dest.first_name, opt => opt.MapFrom(src => src.Forename))
            //.ForMember(dest => dest.legal_first_name, opt => opt.MapFrom(src => src.LegalForename))
            //.ForMember(dest => dest.middle_name, opt => opt.MapFrom(src => src.MiddleName))
            //.ForMember(dest => dest.last_name, opt => opt.MapFrom(src => src.Surname))
            //.ForMember(dest => dest.legal_last_name, opt => opt.MapFrom(src => src.LegalSurname))
            //.ForMember(dest => dest.former_last_name, opt => opt.MapFrom(src => src.FormerSurname))
            //.ForMember(dest => dest.year_code, opt => opt.MapFrom(src => src.Year))
            //.ForMember(dest => dest.dob, opt => opt.MapFrom(src => src.DateOfBirth))
            //.ForMember(dest => dest.former_upn, opt => opt.MapFrom(src => src.FormerUPN))
            //.ForMember(dest => dest.is_eal, opt => opt.MapFrom(src => src.EAL))
            //.ForMember(dest => dest.ethnicity_code, opt => opt.MapFrom(src => src.Ethnicity))
            //.ForMember(dest => dest.service_child, opt => opt.MapFrom(src => src.ServiceChild))
            //.ForMember(dest => dest.sen_category, opt => opt.MapFrom(src => src.SENProvisionDetails[0].ProvisionTypeCode))
            //.ForMember(dest => dest.enrolment_status, opt => opt.MapFrom(src => src.EnrolementStatus))       
            //.ForMember(dest => dest.address_line_1, opt => opt.MapFrom(src => src.AddressDetails[0].Number + " " + src.AddressDetails[0].Street))
            //.ForMember(dest => dest.address_line_2, opt => opt.MapFrom(src => src.AddressDetails[0].Locality))
            //.ForMember(dest => dest.town_city, opt => opt.MapFrom(src => src.AddressDetails[0].Town))
            //.ForMember(dest => dest.county, opt => opt.MapFrom(src => src.AddressDetails[0].County))
            //.ForMember(dest => dest.country, opt => opt.MapFrom(src => src.AddressDetails[0].Country))
            //.ForMember(dest => dest.postcode, opt => opt.MapFrom(src => src.AddressDetails[0].PostCode))
            //.ForMember(dest => dest.start_date, opt => opt.MapFrom(src => src.DateOfEntry))
            //.ForMember(dest => dest.first_language_code, opt => opt.MapFrom(src => src.LanguageDetails[0].LanguageCode)));

            //var mapper = config.CreateMapper();
            OutputModel model = _mapper.Map<OutputModel>(learnerModel);

            return model;
        }

        public OutputDTO OutputModeltoOutputDTO(OutputModel outputModel)
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<OutputModel, OutputDTO>());
            //var mapper = config.CreateMapper();

            OutputDTO dto = _mapper.Map<OutputDTO>(outputModel);

            return dto;
        }
    }
}
