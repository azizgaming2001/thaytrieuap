using DEMO1.DataDBContext;
using DEMO1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DEMO1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly TrainingDBContext _dbContext;
        public CategoryController(TrainingDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CategoryModel categoryModel = new CategoryModel();
            categoryModel.CategoryDetailLists = new List<CategoryDetail>();
            var data = _dbContext.Categories.ToList();
            foreach (var item in data)
            {
                categoryModel.CategoryDetailLists.Add(new CategoryDetail
                {
                    id = item.id,
                    name = item.name,
                    description = item.description,
                    icon = item.icon,
                    status = item.status,
                    created_at = item.created_at,
                    updated_at = item.updated_at
                });
            }

            return View(categoryModel);
        }
        [HttpGet]
        public IActionResult Add()
        {
            CategoryDetail category = new CategoryDetail();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CategoryDetail category, IFormFile Photo) {
            if (ModelState.IsValid)
            {
                try
                {
                    string uniqueFileName = UpLoadFile(Photo);
                    var categoryData = new Category()
                    {
                        name = category.name,
                        description = category.description,
                        icon = uniqueFileName,
                        status = category.status,
                        created_at = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    };
                    _dbContext.Categories.Add(categoryData);
                    _dbContext.SaveChanges();
                    TempData["SaveStatus"] = true;
                }
                catch
                {
                    TempData["SaveStatus"] = false;
                }
                return RedirectToAction(nameof(CategoryController.Index), "Category");

            }
            return View(category);
        }
        private string UpLoadFile(IFormFile file)
        {
            string uniqueFileName;
            try 
            { 
                string pathUploadServer = "wwwroot\\upload\\images";
                string fileName = file.FileName;
                fileName = Path.GetFileName(fileName);
                string uniqueStr = Guid.NewGuid().ToString();//tao ra cac ky tu ko trung lap
                fileName = uniqueStr + "~" + fileName;
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                var stream = new FileStream(uploadPath, FileMode.Create);
                file.CopyToAsync(stream);
                uniqueFileName = fileName;
            }
            catch(Exception ex)
            {
                uniqueFileName = ex.Message.ToString();
            }
            return uniqueFileName;
        }
    }
}