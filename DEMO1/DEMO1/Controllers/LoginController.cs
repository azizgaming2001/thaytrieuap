using DEMO1.Models;
using DEMO1.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DEMO1.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            LoginModel model = new LoginModel();
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            model = new LoginQueries().CheckLoginUser(model.Username, model.Password);
            if(string.IsNullOrEmpty(model.UserID) || string.IsNullOrEmpty (model.Username))
            {
                //dang nhap linh tinh-
                ViewData["MessageLogin"] = "Account invalid";
                return View(model);
            }
            //luu thong tin cua nguoi dung vao session
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUserID")))
            {
                HttpContext.Session.SetString("SessionUserID", model.UserID);
                HttpContext.Session.SetString("SessionRoleID", model.RoleID);
                HttpContext.Session.SetString("SessionUserName", model.Username);
                HttpContext.Session.SetString("SessionEmail", model.Email);
            }
            //chuyen vao trang home
            return RedirectToAction(nameof(HomeController.Index),"Home");
        }
        [HttpPost]
        public IActionResult Logout()
        {
            if(!string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUserID"))){
                HttpContext.Session.Remove("SessionUserID");
                HttpContext.Session.Remove("SessionRoleID");
                HttpContext.Session.Remove("SessionUserName");
                HttpContext.Session.Remove("SessionEmail");
            }
            return RedirectToAction(nameof(LoginController.Index),"Login");
        }
    }
}
