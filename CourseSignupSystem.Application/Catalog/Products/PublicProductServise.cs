using CourseSignupSystem.Data.EF;
using CourseSignupSystem.ViewModel.Common;
using CourseSignupSystem.ViewModels.Catalog.Product;
using CourseSignupSystem.ViewModels.Catalog.Product.Public;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public class PublicProductServise : IPublicProductServise
    {
        private readonly CSSDbContext _context;
        public PublicProductServise(CSSDbContext context)
        {
            _context = context;
        }

        public Task<List<ProducViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedViewModel<ProducViewModel>> GetAllByCategory(GetProductPagingRequest reques)
        {
            throw new NotImplementedException();
        }
    }
}
