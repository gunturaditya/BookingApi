using BokingManagementApp.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace BokingManagementApp.Models
{
    [Table("tb_tr_account_roles")]
    public class AccountRole :BaseEntity
    {
        [Column("account_guid")]
        public Guid AccountGuid { get; set; }

        [Column("role_guid")]
        public Guid RoleGuid { get; set; }

        //cardinalitas
        public Role? Role { get; set; }
        public Account? Account { get; set; }
    }
}
