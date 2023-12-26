﻿using BokingManagementApp.Dto.Role;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;

namespace BokingManagementApp.Service
{
    public class RoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<GetRoleDto>? GetRole()
        {
            var roles = _roleRepository.GetAll();
            if (!roles.Any())
            {
                return null;
            }

            var toDto = roles.Select(role => new GetRoleDto
            {
                Guid = role.Guid,
                Name = role.Name,
            });

            return toDto;
        }

        public GetRoleDto? GetRole(Guid guid)
        {
            var role = _roleRepository.GetByGuid(guid);
            if (role is null)
            {
                return null;
            }

            var toDto = new GetRoleDto
            {
                Guid = role.Guid,
                Name = role.Name,
            };

            return toDto;
        }

        /*public GetRoleDto? GetByName(string name)
        {
            var roles = _roleRepository.GetByName(name);
            if (!roles.Any())
            {
                return null;
            }

            var toDto = roles.Select(role => new GetRoleDto
            {
                Guid = role.Guid,
                Name = role.Name,

            }).ToList();

            return toDto;
        }*/

        public GetRoleDto? CreateRole(NewRoleDto newRoleDto)
        {
            var role = new Role
            {
                Name = newRoleDto.Name,
                Guid = new Guid(),
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var createdRole = _roleRepository.Create(role);
            if (createdRole is null)
            {
                return null;
            }

            var toDto = new GetRoleDto
            {
                Guid = createdRole.Guid,
                Name = createdRole.Name,
            };

            return toDto;

        }

        public int UpdateRole(GetRoleDto updateRoleDto)
        {
            var isExist = _roleRepository.IsExist(updateRoleDto.Guid);
            if (!isExist)
            {
                return -1; // Not Found
            }

            var getRole = _roleRepository.GetByGuid(updateRoleDto.Guid);
            var role = new Role
            {
                Guid = updateRoleDto.Guid,
                Name = updateRoleDto.Name,
                ModifiedDate = DateTime.Now,
                CreatedDate = getRole!.CreatedDate
            };

            var isUpdate = _roleRepository.Update(role);
            if (!isUpdate)
            {
                return 0;
            }

            return 1;
        }

        public int DeleteRole(Guid guid)
        {
            var isExist = _roleRepository.IsExist(guid);
            if (!isExist)
            {
                return -1;
            }

            var role = _roleRepository.GetByGuid(guid);
            var isDelete = _roleRepository.Delete(role!);
            if (!isDelete)
            {
                return 0;
            }

            return 1;
        }
    }
}
