using ASM.Share.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachhangController : ControllerBase
    {
        private readonly IKhachhangSvc _khachhangSvc;
        public KhachhangController(IKhachhangSvc khachhangSvc)
        {
            _khachhangSvc = khachhangSvc;
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostKhachhang(Khachhang khachhang)
        {
            try
            {
                int id = await _khachhangSvc.AddKhachhangAsync(khachhang);
                khachhang.KhachhangID = id;
            }
            catch (Exception ex)
            {

            }
            return Ok(1);
        }
    }
}
