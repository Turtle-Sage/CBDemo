using CBDataLibrary.DTOs;
using CBDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CBDataLibrary.BusinessLogic.Interfaces;

namespace CBDataLibrary.BusinessLogic
{
    public class Mappers : IMappers
    {
        private readonly IMapper _mapper;

        public Mappers(IMapper mapper)
        {
            _mapper = mapper;            
        }

        /// <summary>
        /// Takes a LearnerDTO object and maps the data to a LearnerModel object
        /// </summary>
        /// <param name="learnerDto"></param>
        /// <returns>LearnerModel</returns>
        public LearnerModel LearnerDTOtoLearnerModel(LearnerDTO learnerDto)
        {
            LearnerModel model = _mapper.Map<LearnerModel>(learnerDto);

            return model;
        }

        /// <summary>
        /// Takes a LearnerModel object and maps the data to a OutputModel object
        /// </summary>
        /// <param name="learnerModel"></param>
        /// <returns>OutputModel</returns>
        public OutputModel LearnerModeltoOutputModel(LearnerModel learnerModel)
        {
            OutputModel model = _mapper.Map<OutputModel>(learnerModel);

            return model;
        }

        /// <summary>
        /// Takes a OutputModel object and maps the data to a OutputDTO object
        /// </summary>
        /// <param name="outputModel"></param>
        /// <returns>OutputDTO</returns>
        public OutputDTO OutputModeltoOutputDTO(OutputModel outputModel)
        {
            OutputDTO dto = _mapper.Map<OutputDTO>(outputModel);

            return dto;
        }
    }

    //Mapping profiles used by Automapper
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<LearnerModel, LearnerDTO>();
            CreateMap<LearnerDTO, LearnerModel>();

            CreateMap<OutputModel, OutputDTO>();
            CreateMap<OutputDTO, OutputModel>();

            CreateMap<AddressDetailModel, AddressDetailDTO>();
            CreateMap<AddressDetailDTO, AddressDetailModel>();

            CreateMap<ContactDetailModel, ContactDetailDTO>();
            CreateMap<ContactDetailDTO, ContactDetailModel>();

            CreateMap<SiblingDetailModel, SiblingDetailDTO>();
            CreateMap<SiblingDetailDTO, SiblingDetailModel>();

            CreateMap<DisabilityDetailModel, DisabilityDetailDTO>();
            CreateMap<DisabilityDetailDTO, DisabilityDetailModel>();

            CreateMap<LanguageDetailModel, LanguageDetailDTO>();
            CreateMap<LanguageDetailDTO, LanguageDetailModel>();

            CreateMap<SENProvisionDetailModel, SENProvisionDetailDTO>();
            CreateMap<SENProvisionDetailDTO, SENProvisionDetailModel>();

            CreateMap<LearnerModel, OutputModel>()
            .ForMember(dest => dest.source_id, opt => opt.MapFrom(src => src.LearnerId.ToString()))
            .ForMember(dest => dest.pupil_admission_number, opt => opt.MapFrom(src => src.LearnerCode))
            .ForMember(dest => dest.first_name, opt => opt.MapFrom(src => src.Forename))
            .ForMember(dest => dest.legal_first_name, opt => opt.MapFrom(src => src.LegalForename))
            .ForMember(dest => dest.middle_name, opt => opt.MapFrom(src => src.MiddleName))
            .ForMember(dest => dest.last_name, opt => opt.MapFrom(src => src.Surname))
            .ForMember(dest => dest.legal_last_name, opt => opt.MapFrom(src => src.LegalSurname))
            .ForMember(dest => dest.former_last_name, opt => opt.MapFrom(src => src.FormerSurname))
            .ForMember(dest => dest.year_code, opt => opt.MapFrom(src => src.Year))
            .ForMember(dest => dest.dob, opt => opt.MapFrom(src => src.DateOfBirth))
            .ForMember(dest => dest.former_upn, opt => opt.MapFrom(src => src.FormerUPN))
            .ForMember(dest => dest.is_eal, opt => opt.MapFrom(src => src.EAL))
            .ForMember(dest => dest.ethnicity_code, opt => opt.MapFrom(src => src.Ethnicity))
            .ForMember(dest => dest.service_child, opt => opt.MapFrom(src => bool.Parse(src.ServiceChild)))
            .ForMember(dest => dest.sen_category, opt => opt.MapFrom(src => src.SENProvisionDetails[0].ProvisionTypeCode))
            .ForMember(dest => dest.enrolment_status, opt => opt.MapFrom(src => src.EnrolementStatus))
            .ForMember(dest => dest.address_line_1, opt => opt.MapFrom(src => src.AddressDetails[0].Number + " " + src.AddressDetails[0].Street))
            .ForMember(dest => dest.address_line_2, opt => opt.MapFrom(src => src.AddressDetails[0].Locality))
            .ForMember(dest => dest.town_city, opt => opt.MapFrom(src => src.AddressDetails[0].Town))
            .ForMember(dest => dest.county, opt => opt.MapFrom(src => src.AddressDetails[0].County))
            .ForMember(dest => dest.country, opt => opt.MapFrom(src => src.AddressDetails[0].Country))
            .ForMember(dest => dest.postcode, opt => opt.MapFrom(src => src.AddressDetails[0].PostCode))
            .ForMember(dest => dest.start_date, opt => opt.MapFrom(src => src.DateOfEntry))
            .ForMember(dest => dest.first_language_code, opt => opt.MapFrom(src => src.LanguageDetails[0].LanguageCode));

        }

    }
}
