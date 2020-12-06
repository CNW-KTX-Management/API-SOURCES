using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_KTX_MANAGEMENT.Model
{
    public class SinhVien
    {
        [Key]
        public int Id { get; set; }
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string NgaySinh { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public int GioiTinh { get; set; }
    }
}
