﻿using Application.DTOs;
using Application.Queries.MedialConditionQueries;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.QueryHandlers.MedicalConditionQueryHandlers
{
    public class GetAllMedicalConditionsForPatientQueryHandler : IRequestHandler<GetAllMedicalConditionsQuery, List<MedicalConditionDTO>>
    {
        private readonly IMedicalConditionRepository repository;
        private readonly IMapper mapper;

        public GetAllMedicalConditionsForPatientQueryHandler(IMedicalConditionRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<MedicalConditionDTO>> Handle(GetAllMedicalConditionsQuery request, CancellationToken cancellationToken)
        {
            var medicalConditions = await repository.GetAllAsync(mc => mc.PatientId == request.PatientId);
            return mapper.Map<List<MedicalConditionDTO>>(medicalConditions);
        }
    }
}
