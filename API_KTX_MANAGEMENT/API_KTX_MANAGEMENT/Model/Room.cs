using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_KTX_MANAGEMENT.Model
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int IdKhu { get; set; }
        public string TenPhong { get; set; }
        public int TinhTrang { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongToiDa { get; set; }
    }
}
