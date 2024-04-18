using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository _repository;
        public StudentController(StudentRepository student)
        {
            this._repository = student;
        }
        public IActionResult Index()
        {
            return View(_repository.GetStudents());
        }
        public IActionResult Edit(int id)
        {
            return View(_repository.GetStudent(id));
        }
        [HttpPost]
        public IActionResult Edit(Student obj)
        {
            int ret = _repository.Edit(obj);
            return Redirect(ret); // viết gọn dùng chung hàm Redirect
        }
         IActionResult Redirect(int ret)
        {
            if (ret > 0)
            {
                return Redirect("/student");
            }  
            return Redirect("/student/error");
        }
        
        
        public IActionResult Delete(int id)
        {
            int ret = _repository.Delete(id);
            //if (ret > 0)
            //    return Redirect("/student");
            //return Redirect("/student/error");
            return Redirect(ret); // viết gọn dùng chung hàm Redirect
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student obj)
        {
            int ret = _repository.Add(obj);
            if (ret > 0)
            {
                return Redirect("/student");
            }
            ModelState.AddModelError("Error", "Thêm Lỗi");// thêm dòng "asp-validation-summary="All"" bên Add.cshtml mới chạy đc
            return View(obj);

        }


    }
}
