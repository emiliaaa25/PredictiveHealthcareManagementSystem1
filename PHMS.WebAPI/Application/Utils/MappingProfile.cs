using Application.Commands;
using Application.Commands.MedicalConditionCommands;
using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Patient, PatientDto>().ReverseMap();
            CreateMap<CreatePatientCommand, Patient>().ReverseMap();
            CreateMap<Medic, MedicDto>().ReverseMap();
            CreateMap<CreateMedicCommand, Medic>().ReverseMap();
            CreateMap<UpdateMedicCommand, Medic>().ReverseMap();
            CreateMap<UpdatePatientCommand, Patient>().ReverseMap();
            CreateMap<MedicalCondition, MedicalConditionDTO>().ReverseMap();
            CreateMap<CreateMedicalConditionCommand, MedicalCondition>().ReverseMap();
            CreateMap<UpdateMedicalConditionCommand, MedicalCondition>().ReverseMap();
        }
    }
}
