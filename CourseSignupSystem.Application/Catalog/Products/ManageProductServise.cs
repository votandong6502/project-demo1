using CourseSignupSystem.Data.EF;
using CourseSignupSystem.Data.Entity;
using CourseSignupSystem.ViewModel.Common;
using CourseSignupSystem.ViewModels.Catalog.Product;
using CourseSignupSystem.ViewModels.Catalog.Product.Manage;
using CourseSignupSystemUtilities.Exceptions;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignupSystem.Application.Catalog.Products
{
    public class ManageProductServise : IManageProductServise
    {
        private readonly CSSDbContext _context;
        public ManageProductServise(CSSDbContext context)
        {
            _context = context;
        }

        public async Task AddViewcount (int DSHocVienId)
        {
            var ds = await _context.DSHocViens.FindAsync(DSHocVienId);
            ds.ViewCount += 1;
            await _context.SaveChangesAsync();
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var dsHocVien = new DSHocVien()
            {
                HinhAnh = request.HinhAnh,
                HoTen = request.HoTen,
                PhuHuynh = request.PhuHuynh,
                DiaChi = request.DiaChi,
                NgaySinh = DateTime.Now,
                SDT = request.SDT,
                Email = request.Email,
            };
            _context.DSHocViens.Add(dsHocVien);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Update(ProductEditRequest request)
        {
            var DSHocVien = _context.DSHocViens.FindAsync(request.id);
            if (DSHocVien == null) throw new CSSExceptions($"cannot find a student with id:{request.id}");
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int DSHocVienId)
        {
            if (DSHocVien == null) throw new CSSExceptions($"cannot find a student:{DSHocVienId}");
            var ds = await _context.DSHocViens.FindAsync(DSHocVienId);
            _context.DSHocViens.Remove(DSHocVien);
            return await _context.SaveChangesAsync();

        }


        public async Task<PagedViewModel<ProducViewModel>> GetAllpaging(string TimKiem, int SoTT, int KichCo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateMAHV(int id, int newMAHV)
        {
            var dsHocVien = await _context.DSHocViens.FindAsync(id);
            if(dsHocVien == null) throw new CSSExceptions($"cannot find a student:{id}");
            dsHocVien.MaHV = newMAHV;
            return await _context.SaveChangesAsync() > 0;

        }

        public Task<bool> UpdateHoTen(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedViewModel<ProducViewModel>> GetAllpaging(GetProductPagingReques reques)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProducViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
