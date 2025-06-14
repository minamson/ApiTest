using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entity
{

    [Table("SD_DEPT")]
    public class Dept
    {
        [Key]
        [Column("DEPT_NO")]
        public long DeptNo { get; set; }

        [Column("DEPT_NAME")]
        public string DeptName{ get; set; }

        [Column("REMARK")]
        public string Remark {  get; set; }
    }
}
