using System.Collections.Generic;
using Models;

namespace BusinessLogicLayer
{
    public interface IProductService
    {
        List<ProductModel> GetAllData();
    }
}