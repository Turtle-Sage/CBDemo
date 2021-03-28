using System;
using System.Collections.Generic;
using AutoMapper;
using CBDataLibrary.BusinessLogic;
using CBDataLibrary.DTOs;
using CBDataLibrary.Models;
using Microsoft.Extensions.DependencyInjection;


namespace CBApp
{
    class Program
    {
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddTransient<ILearner, Learner>();
            services.AddTransient<IMappers, Mappers>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            ILearner learner = serviceProvider.GetRequiredService<ILearner>();
                      
            string jsonOutput = learner.GetLearner();
            Console.WriteLine(jsonOutput);
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
