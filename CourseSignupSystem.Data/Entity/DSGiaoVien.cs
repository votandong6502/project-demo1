﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSignupSystem.Data.Entity
{
    [Table("DSGiaoVien")]
    public partial class DSGiaoVien
    {
        [StringLength(50)]
        public string id { get; set; }

        [Column(TypeName = "text")]
        public string AnhDaiDien { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public int? DT { get; set; }

        [StringLength(10)]
        public string Email { get; set; }
    }
}
