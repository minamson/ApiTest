using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    [Table("SCHEM_INFO")]
    public class Schema
    {
        
        public Schema() { }

        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("TABLE_NAME")]
        public string TableName { get; set; }

        [Column("COLUMN_ID")]
        public int ColumnId { get; set; }

        [Column("COLUMN_NAME")]
        public string ColumnName { get; set; }

        [Column("COMMENTS")]
        public string Comments { get; set; }

        [Column("DATA_TYPE")]
        public string DataType { get; set; }

        //[Column("DATA_LENGTH")]
        //public int DataLength { get; set; }

        [Column("ISNULL")]
        public string IsNull { get; set; }

        [Column("DATA_DEFAULT")]
        public string DataDefault { get; set; }

        [Column("PK")]
        public string PK { get; set; }
        [Column("FK")]
        public string FK { get; set; }
        [Column("UQ")]
        public string UQ { get; set; }

    }
}
