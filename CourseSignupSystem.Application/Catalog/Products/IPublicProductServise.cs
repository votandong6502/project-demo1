using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CourseSignupSystem.ViewModel.Common;
using CourseSignupSystem.ViewModels.Catalog.Product;
using CourseSignupSystem.ViewModels.Catalog.Product.Manage;
using CourseSignupSystem.ViewModels.Catalog.Product.Public;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public interface IPublicProductServise
    {
        Task<PagedViewModel<ProducViewModel>> GetAllByCategory(GetProductPagingRequest reques);
        Task<List<ProducViewModel>>GetAll();
    }
}
