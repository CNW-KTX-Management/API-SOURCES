using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_KTX_MANAGEMENT.Model
{
    public class HopDong
    {
        [Key]
        public int Id { get; set; }
        public int IdSinhVien { get; set; }
        public int IdNhanVien { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string NgayLap { get; set; }
        public int TinhTrang { get; set; }
        public string NgayLamDon { get; set; }
    }
}
