using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DEMO1.DBContext
{
    public class TrainerTestRoles
    {
        [Key] public int Id { get; set; }
        [Column("NameCategory", TypeName = "Varchar(50)")]
        public string NameRole { get; set; }
        [Column("Description", TypeName = "Varchar(100)")]
        public string Description { get; set; }

        [Column("Status", TypeName = "Integer")]
        public int Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
    }
}
