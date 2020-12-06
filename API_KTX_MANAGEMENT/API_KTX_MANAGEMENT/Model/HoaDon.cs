using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_KTX_MANAGEMENT.Model
{
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }
        public int IdRoom { get; set; }
        public int IdNhanVien { get; set; }
        public int IdDien { get; set; }
        public int IdNuoc { get; set; }
        public string NgayLap { get; set; }
        public int SoDienCu { get; set; }
        public int SoDienMoi { get; set; }
        public int SoNuocCu { get; set; }
        public int SoNuocMoi { get; set; }
        public double ThanhTien { get; set; }
    }
}
