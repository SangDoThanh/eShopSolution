using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Common;
using eShopSolution.Application.Dtos;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly EShopDbContext _context;
        private readonly IStorageService _storageService;
        public ManageProductService(EShopDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }


        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        Task<int> IManageProductService.Delete(int productId)
        {
            throw new NotImplementedException();
        }

        Task<List<ProductViewModel>> IManageProductService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<PageViewModel<ProductViewModel>> IManageProductService.GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<int> IManageProductService.Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
