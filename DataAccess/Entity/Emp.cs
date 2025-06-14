using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entity
{
    [Table("MM_EMP")]
    public class Emp
    {
        [Key]
        [Column("EMP_NO")]
        public long EmpNo { get; set; }
        [Column("EMP_NAME")]
        public string EmpName { get; set; }
        [Column("DEPT_NO")]
        public long DeptNo { get; set; }
        [Column("REMARK")]
        public string Remark { get; set; }
    }
}
