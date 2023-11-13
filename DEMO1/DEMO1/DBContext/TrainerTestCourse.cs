using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMO1.DBContext
{
    public class TrainerTestCourse
    {
        [Key] public int Id { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual IdentityUser Category { get; set; }

        [Column("NameCourse", TypeName = "Varchar(50)")]
        public string NameCourse { get; set; }
        [Column("Description", TypeName = "Varchar(50)")]
        public string Description { get; set; }
        [Column("Vote", TypeName = "Integer")]
        public int Vote { get; set; }

        [Column("Status", TypeName = "Integer")]
        public int Status { get; set; }
        [Column("StartDate", TypeName = "DateOnly")]
        public DateOnly StartDate { get; set; }
        [Column("EndDate", TypeName = "DateOnly")]
        public DateOnly EndDate { get; set; }

        [Column("Avatar", TypeName = "Varchar(100)")]
        public string Avartar { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
    }
}
