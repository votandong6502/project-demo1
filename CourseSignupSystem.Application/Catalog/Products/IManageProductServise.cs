﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CourseSignupSystem.ViewModel.Common;
using CourseSignupSystem.ViewModels.Catalog.Product;
using CourseSignupSystem.ViewModels.Catalog.Product.Manage;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public interface IManageProductServise
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductEditRequest request);
        Task<int> Delete(int productId);
        Task<bool> UpdateMAHV(int id ,int newMAHV);
        Task<bool> UpdateHoTen(int id);
        Task  AddViewcount(int id);
        Task<List<ProducViewModel>> GetAll();
        Task<PagedViewModel<ProducViewModel>> GetAllpaging(GetProductPagingReques reques);

    }
}
