using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_KTX_MANAGEMENT.Model
{
    public class NhanVien
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChucVu { get; set; }
        public string Phone { get; set; }
        public string DiaChi { get; set; }
        public int GioiTinh { get; set; }
        public int Status { get; set; }
    }
}
