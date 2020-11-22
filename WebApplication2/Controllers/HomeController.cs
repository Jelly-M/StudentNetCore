using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
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
        public IActionResult Create(Student student)
        {
            //模型验证
            if (ModelState.IsValid)
            {
                Student newStudnet = _studentRepository.Add(student);
               // return RedirectToAction("detail", new { id = newStudnet.Id });
            }
            return View();
        }
    }
}