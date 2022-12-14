using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Web.Data.Table
{
    public enum TrangThai
    {
        Online = 0, Ofline = 1
        
    }
    [Table("NguoiDung")]
    public class NguoiDungDb
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int IDPhanQuyen { get; set; }
        [Required]
        public string TenTk { get; set; }
        [Required]
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        [MaxLength(10)]
        public string SDT { get; set; }
        public TrangThai TrangThai { get; set; }
        [Required]
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }

    }
}
