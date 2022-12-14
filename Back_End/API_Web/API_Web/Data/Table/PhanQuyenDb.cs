using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace API_Web.Data.Table
{
    [Table("PhanQuyen")]
    public class PhanQuyenDb
    {
        [Key]
        public int IDPhanQuyen { get; set; }
        [Required]
        public string TenQuyen { get; set; }
        [Required]
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }

    }
}
