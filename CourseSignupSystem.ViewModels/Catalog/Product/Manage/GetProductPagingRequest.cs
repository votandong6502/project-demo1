using CourseSignupSystem.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.ViewModels.Catalog.Product.Manage
{
    public class GetProductPagingReques : PagingRequestBase
    {
        public string TimKiem { get; set; }
        public List<int> DSHocVienID { get; set; }
    }
}
