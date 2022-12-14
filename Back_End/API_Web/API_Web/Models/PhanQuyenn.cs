using System.ComponentModel.DataAnnotations;
using System;

namespace API_Web.Models
{
    public class PhanQuyenn
    {
        [Required]
        public string TenQuyen { get; set; }
        [Required]
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
