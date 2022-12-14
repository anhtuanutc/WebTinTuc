using API_Web.Data.Table;
using API_Web.Data;
using API_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using API_Web.Controllers.Admin.PhucTap;
using Microsoft.AspNetCore.Http;

namespace API_Web.Controllers.Admin.DonGian
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheLoaiAPI : ControllerBase
    {
        private readonly MyDbContext _context;
        public TheLoaiAPI(MyDbContext context)
        {
            _context = context;
        }

        //Lấy tất cả
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsTheLoai = _context.TheLoaiDb.ToList();
            return Ok(dsTheLoai);
        }
        //Lấy theo id
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            
            try
            {
                var theloai = _context.TheLoaiDb.SingleOrDefault(nt => nt.IDTheLoai == int.Parse(id));
                if (theloai == null)
                {
                    return NotFound();
                }
                return Ok(theloai); 
            }
            catch
            {
                return BadRequest();
            }
        }
        //Check xem có bài viết nào tồn tại thể loại nào không
        [Route("Tuan123/{IDTheLoai}")]
        [HttpGet]
        public IActionResult CheckbyId(string IDTheLoai)
        {
            try
            {
                var theloai = _context.BaiVietDb.Where(nt => nt.IDTheLoai == int.Parse(IDTheLoai));
                if (theloai == null)
                {
                    return NotFound();
                }
                return Ok(theloai);
            }
            catch
            {
                return BadRequest();
            }
        }
        //Thêm
        [HttpPost]
        public IActionResult Create(TheLoaii TheLoaiAdd)
        {
            try
            {
                var theloai = new TheLoaiDb
                {
                    TenTheLoai = TheLoaiAdd.TenTheLoai,
                    NgayTao = DateTime.Now,
                    NguoiTao = "ADMIN"

                };
                _context.Add(theloai);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, theloai);
            }
            catch
            {
                return BadRequest();
            }
        }
        //Sửa
        [HttpPut("{id}")]
        public IActionResult Edit(string id, TheLoaii TheLoaiEdit)
        {
            try
            {
                var theloai = _context.TheLoaiDb.SingleOrDefault(nt => nt.IDTheLoai == int.Parse(id));
                if (theloai == null)
                {
                    return NotFound();
                }
                if (id != theloai.IDTheLoai.ToString())
                {
                    return BadRequest();
                }
                theloai.TenTheLoai = TheLoaiEdit.TenTheLoai;
                theloai.NgaySua = DateTime.Now;
                theloai.NguoiSua = "ADMIN";
                _context.SaveChanges();
                return Ok();

            }
            catch
            {
                return BadRequest();
            }
        }
        //Xóa
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var theloai = _context.TheLoaiDb.SingleOrDefault(nt => nt.IDTheLoai == int.Parse(id));
                if (theloai == null)
                {
                    return NotFound();
                }
                _context.Remove(theloai);
                _context.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
