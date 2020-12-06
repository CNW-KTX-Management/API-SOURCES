using API_KTX_MANAGEMENT.Context;
using API_KTX_MANAGEMENT.Mapper;
using API_KTX_MANAGEMENT.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_KTX_MANAGEMENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public SinhVienController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/sinhvien
        [HttpGet]
        public SinhVienMapper GetListSinhVien()
        {
            List<SinhVien> list = _context.SinhVien.ToList();
            SinhVienMapper sv = new SinhVienMapper(list);
            return sv;
        }
    }
}
