﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CourseSignupSystem.Data.Entity
{
    [Table("dangnhap")]
    public partial class dangnhap
    {
        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string passwork { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [Key]
        public int userid { get; set; }
    }
}
