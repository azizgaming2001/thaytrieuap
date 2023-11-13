using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DEMO1.DBContext
{
    public class TrainerTestCategories
    {
        //taoj cacs cot
        [Key] public int Id { get; set; }
        [Column("NameCategory", TypeName ="Varchar(50)") ]
        public string NameCategory { get; set; }
        [Column("Description", TypeName = "Varchar(100)")]
        public string Description { get; set; }
        [Column("Icon", TypeName = "Varchar(50)")]
        public string icon { get; set; }

        [Column("Status", TypeName = "Integer")]
        public int Status { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }

    }
}
