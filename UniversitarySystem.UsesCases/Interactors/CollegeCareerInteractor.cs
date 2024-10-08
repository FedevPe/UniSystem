﻿using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers;
using UniversitarySystem.UsesCases.BusinessObject.Repository;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.Interactors
{
    public class CollegeCareerInteractor(
        ICollegeCareerOutputPort outputPort,
        ICollegeCareerRepository repository) : ICollegeCareerInputPort
    {
        public async Task Handle(CollegeCareerDTO collegeCareer)
        {
            var entity = new CollegeCareerEntity
            {
                CollegeCareer = collegeCareer.Name,
                Description = collegeCareer.Description,
                Duration = collegeCareer.Duration,
                TypeCareersId = collegeCareer.TypeId,
                Mode = collegeCareer.Mode,
                Status = collegeCareer.Status
            };

            await repository.AddCollegeCareer(entity);
            await repository.SaveChanges();
            await outputPort.Handle(entity);
        }
        public async Task GetListCareers()
        {
            await outputPort.HandleList(await repository.GetAllCollegeCareers());
        }
    }
}
