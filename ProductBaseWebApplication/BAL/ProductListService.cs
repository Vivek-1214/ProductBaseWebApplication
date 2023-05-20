using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProductBaseWebApplication.DAL;
using ProductBaseWebApplication.Models;

namespace ProductBaseWebApplication.BAL
{
    public class ProductListService: IproductListService
    {
        private readonly ProductContext db;
        public ProductListService(ProductContext _db)
        {
            this.db = _db;
        }
        public List<ProductListVM> GetAllProduct()
        {
            List<ProductList> products= db.ProductLists.ToList();

            List<ProductListVM> ProductVM = new List<ProductListVM>();

            foreach (var product in products)
            {
                ProductListVM productVM = new ProductListVM();

                productVM.Id = product.Id;
                productVM.Name = product.Name;
                productVM.Color = product.Color;
                productVM.Prices = product.Prices;


                ProductVM.Add(productVM);
            }

            return ProductVM;
        }

        public void DeleteCustomer(int id) {
         var product=   db.ProductLists.Find(id);
            if (product != null ) 
            {
                db.ProductLists.Remove(product);
                db.SaveChanges();
            }
       }

           public void AddProduct(AddVM addVM)
        {
              ProductList Product = new ProductList();
            Product.Id = addVM.Id;
            Product.Name = addVM.Name;
            Product.Color = addVM.Color;
            Product.Prices = addVM.Prices;


            db.ProductLists.Add(Product);
            db.SaveChanges();

        }

        public EditVM GetSingleProduct(int id)
        {
            var product = db.ProductLists.Find(id);

            EditVM editVM = null;
            if (product != null)
            {
                editVM = new EditVM(product);
            }

            return editVM;
        }
    

        public void EditProduct(EditVM editVM)
        {
           var product= db.ProductLists.FirstOrDefault(P => P.Id== editVM.Id);
            if (product != null)
            {
                 product.Name = editVM.Name;
                product.Color = editVM.Color;
                product.Prices = editVM.Prices;

                db.Update(product);
                db.SaveChanges();
            }
        }

    }
}
