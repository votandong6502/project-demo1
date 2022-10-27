using CourseSignupSystem.Application.Catalog.Products;
using CourseSignupSystem.ViewModels.Catalog.Product.Manage;
using CourseSignupSystem.ViewModels.Catalog.Product.Public;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignupSystem.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DSHocSinh : ControllerBase
    {
        private readonly IPublicProductServise _publicProductServise;
        private readonly IManageProductServise _publicManageProductServise;
        public DSHocSinh(IPublicProductServise publicProductServise,IManageProductServise manageProduct)
        {
            _publicProductServise = publicProductServise;
            _publicManageProductServise = manageProduct;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ds = await _publicProductServise.GetAll();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetProductPagingRequest request)
        {
            var ds = await _publicProductServise.GetAllByCategory(request);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetByID()
        {
            var ds = await _publicProductServise.get();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ProductCreateRequest request)
        {
            var result = await _publicManageProductServise.Create(request);
            if(result == 0)
            {
                return BadRequest();
            }    
            return Create("");
        }
    } 
}
