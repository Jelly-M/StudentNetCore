using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebApplication2.Models;
using Microsoft.AspNetCore.Http;

namespace WebApplication2.ViewModels
{
    public class StudentCreateViewModel
    {
        //public int Id { get; set; } //创建学生时不需要ID

        [Required(ErrorMessage = "名字必填"), Display(Name = "名字")]
        public string Name { get; set; }

        [Display(Name = "邮箱")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "邮箱格式不正确"), Required(ErrorMessage = "邮箱必填")]
        public string Email { get; set; }

        [Display(Name = "年级")]
        [Required]
        public ClassNameEnum? Gread { get; set; }

        [Display(Name = "图片")]
        public List<IFormFile> Photos { get; set; }
    }
}
