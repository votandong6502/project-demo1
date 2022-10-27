﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.ViewModels.Catalog.Product.Manage
{
    public class ProductCreateRequest
    {
        public string MaHV { get; set; }

        public string HinhAnh { get; set; }

        public string HoTen { get; set; }

        public string PhuHuynh { get; set; }

        public string DiaChi { get; set; }

        public DateTime? NgaySinh { get; set; }

        public int? SDT { get; set; }

        public string Email { get; set; }
    }
}
