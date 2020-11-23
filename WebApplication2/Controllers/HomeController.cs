using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IStudentRepository studentRepository,IHostingEnvironment hostingEnvironment)
        {
            _studentRepository = studentRepository;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index(int id)
        {
            // return _studentRepository.GetStudent(1).Email;
            var listStudent = _studentRepository.GetAllStudents();

            return View(listStudent);
        }

        public IActionResult detail(int id)
        {
            var model = _studentRepository.GetStudent(id);
            var viewModel = new StudentViewModel()
            {
                Title = "学生详情页",
                student = model
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentCreateViewModel model)
        {
            //模型验证
            if (ModelState.IsValid)
            {
                string uniqueFileName = string.Empty;
                if(model.Photos!=null&&model.Photos.Count>0)
                {
                    //图片上传的路径
                    string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "img");
                    foreach (var Photo in model.Photos)
                    {
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                        string filePath = Path.Combine(uploadFolder, uniqueFileName);
                        //将文件拷贝到文件夹中去
                        Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    }

                   
                   
                }
                Student student = new Student() { 
                    Name=model.Name,
                    Email=model.Email,
                    Gread=model.Gread,
                    Photo= uniqueFileName
                };
                Student newStudnet = _studentRepository.Add(student);
               return RedirectToAction("detail", new { id = newStudnet.Id });
            }
            return View();
        }
        [HttpGet]
        public ViewResult edit(int id)
        {
            var student = _studentRepository.GetStudent(id);
            if (student != null)
            {
                StudentEditViewModel studentEditViewModel = new StudentEditViewModel() {
                    Id = id,
                    Name=student.Name,
                    Email=student.Email,
                    ExistsPath=student.Photo,
                    Gread=student.Gread
                
                };
                return View(studentEditViewModel);
            }
            return View();

        }
        [HttpPost]
        public IActionResult edit(StudentEditViewModel studentEditView)
        {

        }
    }
}