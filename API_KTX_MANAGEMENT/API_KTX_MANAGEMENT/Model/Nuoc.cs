using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_KTX_MANAGEMENT.Model
{
    public class Nuoc
    {
        [Key]
        public int Id { get; set; }
        public double GiaNuoc { get; set; }
    }
}
