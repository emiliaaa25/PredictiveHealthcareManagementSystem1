using Application.Commands.Administrator;
using Application.Commands.Medic;
using Application.Commands.MedicalConditionCommands;
using Application.Commands.Patient;
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
            CreateMap<Admin, AdminDto>().ReverseMap();
            CreateMap<UpdateAdminCommand, Admin>().ReverseMap();
            CreateMap<MedicalCondition, MedicalConditionDto>().ReverseMap();
            CreateMap<CreateMedicalConditionCommand, MedicalCondition>().ReverseMap();
            CreateMap<UpdateMedicalConditionCommand, MedicalCondition>().ReverseMap();
        }
    }
}
