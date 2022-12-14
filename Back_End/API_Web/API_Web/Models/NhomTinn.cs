using System.ComponentModel.DataAnnotations;
using System;

namespace API_Web.Models
{
    public class NhomTinn
    {
        [Required]
        public string TenNhomTin { get; set; }
        [Required]
        public int ThuTuHienThi { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
