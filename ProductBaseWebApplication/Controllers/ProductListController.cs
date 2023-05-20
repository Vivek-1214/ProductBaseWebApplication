using Microsoft.AspNetCore.Mvc;
using ProductBaseWebApplication.BAL;
using ProductBaseWebApplication.Models;

namespace ProductBaseWebApplication.Controllers
{
    public class ProductListController : Controller
    {
        private readonly IproductListService ProductListService;

        public ProductListController(IproductListService _ProductListService)
        {
            this.ProductListService = _ProductListService;
        }
        public IActionResult Index()
        {
            var product = ProductListService.GetAllProduct();

            return View(product);
        }

        public IActionResult Add()
        {
            AddVM addVM = new AddVM();

            return View(addVM);
        }

        [HttpPost]
        public IActionResult Add(AddVM addVM)
        {

            if (ModelState.IsValid == true)
            {
                ProductListService.AddProduct(addVM);

                return RedirectToAction("Index");
            }

            return View(addVM);
        }

        public IActionResult Delete(int id)
        {

            ProductListService.DeleteCustomer(id);

            return RedirectToAction("Index"); ;
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customerVm = ProductListService.GetSingleProduct(id);



            return View(customerVm);
        }

        [HttpPost]
        public IActionResult Edit(EditVM editVM)
        {
          if (ModelState.IsValid == true)
            {

                ProductListService.EditProduct(editVM);

                return RedirectToAction("Index");
            }

            return View(editVM);
        }
    }

}
