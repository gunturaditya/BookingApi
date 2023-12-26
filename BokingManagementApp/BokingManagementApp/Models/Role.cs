using BokingManagementApp.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BokingManagementApp.Models
{
    [Table("tb_m_roles")]
    public class Role :BaseEntity
    {
        [Column("name", TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        //cardinalitas

        public ICollection<AccountRole>? AccountRoles { get; set; }
    }
}
