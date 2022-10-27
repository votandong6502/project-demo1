using CourseSignupSystem.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystem.ViewModels.Catalog.Product.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int DSHocVienId { get; set; }
    }
}
