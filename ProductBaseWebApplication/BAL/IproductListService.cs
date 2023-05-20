using ProductBaseWebApplication.Models;

namespace ProductBaseWebApplication.BAL
{
    public interface IproductListService
    {
        List<ProductListVM> GetAllProduct();

        void AddProduct(AddVM addVM);

        void DeleteCustomer(int id);

        EditVM GetSingleProduct(int id);

         void EditProduct(EditVM editVM);
    }
}
