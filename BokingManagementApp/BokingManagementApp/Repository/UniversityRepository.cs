using BokingManagementApp.Base;
using BokingManagementApp.Context;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BokingManagementApp.Repository
{
    public class UniversityRepository : BaseRepository<University>,IUniversityRepository
    {
        public UniversityRepository(BookingContext context) : base(context)
        {
        }
        public IEnumerable<University> GetByName(string name)
        {
            return _context.Universities.Where(x => x.Name.Contains(name));
        }

        public University? GetByCodeName(string code, string name)
        {
            return _context.Universities.FirstOrDefault(x => x.Code.ToLower()
                                                             == code.ToLower()
                                                             && x.Name.ToLower()
                                                             == name.ToLower());
        }
        public bool IsNameExist(string name)
        {
            return  _context.Set<University>().Any(x => x.Name == name);
        }

        public University? GetName(string name)
        {
            return _context.Set<University>().FirstOrDefault(x => x.Name == name);
        }

        public override University? Create(University entity)
        {
            if(IsNameExist(entity.Name))
            {
                var getdata = GetName(entity.Name);

                University university = new University()
                {
                    Guid = getdata.Guid,
                    Name = getdata.Name,
                    Code = getdata.Code,
                };
                return university;
            }
            var univ = new University()
            {
                Guid = entity.Guid,
                Name = entity.Name,
                Code = GeneratedCode()
            };
 
            return base.Create(univ);
        }

        public string GeneratedCode()
        {
            var lastUniv = GetAll();

            if (!lastUniv.Any())
            {
                return "S001";
            }

            var lastData = lastUniv.LastOrDefault();
            var code = "SB" + (int.Parse(lastData.Code.Substring(2,2)) + 1).ToString();

            return code;
        }
    }
}
