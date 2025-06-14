using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class BizModule
    {
        public int Id { get; set; }
        public string Module { get; set; }
    }
}
