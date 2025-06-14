using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class FuelPrice
    {
        public long Id {  get; set; }
        public int Day { get; set; }
        public string Days {  get; set; }
        public int Price { get; set; }
    }
}
