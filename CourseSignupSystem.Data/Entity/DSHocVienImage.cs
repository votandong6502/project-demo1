using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.Data.Entity
{
    public class DSHocVienImage
    {
        public int Id { get; set; }
        public int DSHocVienID { get; set; }
        public string DuongDanAnh { get; set; }
        public string TenAnh { get; set; }
        public bool AnhMacDInh { get; set; }
        public DateTime NgayTao { get; set; }
        public int ThuTu { get; set; }
        public int FilSize { get; set; }
        public DSHocVien DSHocVien { get; set; }
    }
}
