using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{

    [Table("SCHEM_INFO")]
    public class Schema
    {
        
        public Schema() { }

        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("TABLE_NAME")]
        public string TABLE_NAME { get; set; }

        [Column("KIND")]
        public string KIND { get; set; }

        [Column("COLUMN_ID")]
        public int? COLUMN_ID { get; set; }

        [Column("COLUMN_NAME")]
        public string COLUMN_NAME { get; set; }

        [Column("COMMENTS")]
        public string COMMENTS { get; set; }

        [Column("DATA_TYPE")]
        public string DATA_TYPE { get; set; }

        [Column("ISNULL")]
        public string ISNULL { get; set; }

        [Column("DATA_DEFAULT")]
        public string DATA_DEFAULT { get; set; }

        [Column("PK")]
        public string PK { get; set; }
        [Column("FK")]
        public string FK { get; set; }
        [Column("UQ")]
        public string UQ { get; set; }

    }
}
