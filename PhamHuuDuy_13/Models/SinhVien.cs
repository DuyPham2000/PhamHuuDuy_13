using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhamHuuDuy_13.Models
{
    [Table("SinhViens")]
    public class SinhVien
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
    }
}