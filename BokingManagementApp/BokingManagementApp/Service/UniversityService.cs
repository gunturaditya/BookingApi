using BokingManagementApp.Dto.University;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;
using BokingManagementApp.Repository;

namespace BokingManagementApp.Service
{
    public class UniversityService
    {
        private readonly IUniversityRepository _universityRepository;

        public UniversityService(IUniversityRepository universityRepository)
        {
            _universityRepository = universityRepository;
        }

        public IEnumerable<GetUniversityDto>? GetUniversity()
        {
            var universities = _universityRepository.GetAll();
            if (!universities.Any())
            {
                return null;
            }

            var toDto = universities.Select(x => new GetUniversityDto
            {
                Guid = x.Guid,
                Name = x.Name,
                Code = x.Code
            });

            return toDto;
        }

        public GetUniversityDto? GetUniversity(Guid guid)
        {
            var university = _universityRepository.GetByGuid(guid);
            if (university is null)
            {
                return null; // University not found
            }

            var toDto = new GetUniversityDto
            {
                Guid = university.Guid,
                Code = university.Code,
                Name = university.Name
            };

            return toDto; // Universities found
        }

        public IEnumerable<GetUniversityDto>? GetUniversity(string name)
        {
            var universities = _universityRepository.GetByName(name);
            if (!universities.Any())
            {
                return null; // No universities found
            }

            var toDto = universities.Select(x => new GetUniversityDto
            {
                Guid = x.Guid,
                Code = x.Code,
                Name = x.Name
            }).ToList();

            return toDto; // Universities found
        }

        public GetUniversityDto? CreateUniversity(NewUniversityDto newUniversityDto)
        {
            var university = new University
            {
                Code = newUniversityDto.Code,
                Name = newUniversityDto.Name,
                Guid = new Guid(),
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var createdUniversity = _universityRepository.Create(university);
            if (createdUniversity is null)
            {
                return null; // University not created
            }

            var toDto = new GetUniversityDto
            {
                Guid = createdUniversity.Guid,
                Code = createdUniversity.Code,
                Name = createdUniversity.Name
            };

            return toDto; // University created

        }

        public int UpdateUniversity(GetUniversityDto updateUniversityDto)
        {
            var isExist = _universityRepository.IsExist(updateUniversityDto.Guid);
            if (!isExist)
            {
                return -1; // Not Found
            }

            var getUniversity = _universityRepository.GetByGuid(updateUniversityDto.Guid);
            var university = new University
            {
                Guid = updateUniversityDto.Guid,
                Code = updateUniversityDto.Code,
                Name = updateUniversityDto.Name,
                ModifiedDate = DateTime.Now,
                CreatedDate = getUniversity!.CreatedDate
            };

            var isUpdate = _universityRepository.Update(university);
            if (!isUpdate)
            {
                return 0; // University not updated
            }

            return 1; /// Succes Update
        }

        public int DeleteUniversity(Guid guid)
        {
            var isExist = _universityRepository.IsExist(guid);
            if (!isExist)
            {
                return -1; // University not found
            }

            var university = _universityRepository.GetByGuid(guid);
            var isDelete = _universityRepository.Delete(university!);
            if (!isDelete)
            {
                return 0; // University not deleted
            }

            return 1;
        }
        public string GenerateCode()
        {
            var lastUniv = _universityRepository.GetAll();

            if (!lastUniv.Any())
            {
                return "S001";
            }

            var lastData = lastUniv.LastOrDefault();
            var code = "S" + (int.Parse(lastData.Code.Substring(1)) + 1).ToString();

            return code;
        }
    }
}
